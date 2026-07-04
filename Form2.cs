using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Kick_Chat
{
    public partial class Form2 : Form
    {
        private string chatUrl;
        private bool showBorder;
        private int zoomPct;
        private bool isLoaded = false;
        private bool firstLoad = true;
        private bool isReconnecting = false;
        private bool lastConnectionStatus = true;
        private System.Windows.Forms.Timer connectionCheckTimer;

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOACTIVATE = 0x0010;

        private int backgroundOpacityPct;
        private System.Windows.Forms.Timer opacityTimer;
        private int pendingOpacity;

        private int failedAttempts = 0;
        private const int MaxFailedAttempts = 3;

        public Form2(string url, bool border, int zoom)
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.Padding = Padding.Empty;
            this.Margin = Padding.Empty;

            chatUrl = url;
            showBorder = border;
            zoomPct = zoom;
            backgroundOpacityPct = Properties.Settings.Default.BGOpacity;

            Load += Form2_Load;
            FormClosing += Form2_FormClosing;
            Move += Form2_MoveResize;
            ResizeEnd += Form2_MoveResize;

            NetworkChange.NetworkAddressChanged += OnNetworkAddressChanged;

            connectionCheckTimer = new System.Windows.Forms.Timer();
            connectionCheckTimer.Interval = 1000;
            connectionCheckTimer.Tick += ConnectionCheckTimer_Tick;
            connectionCheckTimer.Start();

            opacityTimer = new System.Windows.Forms.Timer();
            opacityTimer.Interval = 16;
            opacityTimer.Tick += (s, e) =>
            {
                opacityTimer.Stop();
                if (webView21 != null && webView21.CoreWebView2 != null)
                {
                    double alpha = pendingOpacity / 100.0;
                    _ = webView21.ExecuteScriptAsync($"document.body.style.setProperty('background-color','rgba(0,0,0,{alpha})','important');");
                }
            };
        }
        public void UpdateOpacity(int percentage)
        {
            backgroundOpacityPct = percentage;
            pendingOpacity = percentage;

            if (!opacityTimer.Enabled)
            {
                opacityTimer.Start();
            }
        }
        private async void ConnectionCheckTimer_Tick(object sender, EventArgs e)
        {
            if (isReconnecting) return;
            bool currentStatus = await CheckInternetAccess();

            if (currentStatus)
            {
                failedAttempts = 0;
                if (!lastConnectionStatus || !webView21.Visible)
                {
                    ReloadWebView();
                }
                lastConnectionStatus = true;
            }
            else
            {
                failedAttempts++;
                if (failedAttempts >= MaxFailedAttempts)
                {
                    lastConnectionStatus = false;
                }
            }
        }
        private async Task<bool> CheckInternetAccess()
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(4);
                    using (var response = await client.GetAsync("https://kick-chat.corard.tv/"))
                    {
                        return response.IsSuccessStatusCode;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        private async void OnNetworkAddressChanged(object sender, EventArgs e)
        {
            if (isReconnecting) return;
            isReconnecting = true;
            await Task.Delay(100);
            ReloadWebView();
            isReconnecting = false;
        }
        private void ReloadWebView()
        {
            if (!this.IsDisposed && webView21 != null)
            {
                this.BeginInvoke(new Action(() => { try { webView21.Reload(); } catch { } }));
            }
        }
        private async void Form2_Load(object sender, EventArgs e)
        {
            ApplyBorder(showBorder);

            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;

            TopMost = true;
            ShowInTaskbar = false;

            if (firstLoad)
            {
                this.StartPosition = FormStartPosition.Manual;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.ChatBoxBounds))
                {
                    try
                    {
                        string[] parts = Properties.Settings.Default.ChatBoxBounds.Split(',');
                        if (parts.Length == 4)
                        {
                            Location = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                            Size = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                        }
                    }
                    catch { }
                }
                firstLoad = false;
            }

            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);

            isLoaded = true;

            try
            {
                if (webView21 != null && !webView21.IsDisposed)
                {
                    await webView21.EnsureCoreWebView2Async();
                    webView21.DefaultBackgroundColor = Color.Transparent;
                    webView21.Dock = DockStyle.Fill;
                    webView21.Margin = Padding.Empty;
                    webView21.NavigationCompleted += WebView21_NavigationCompleted;
                    webView21.Source = new Uri(chatUrl);
                    webView21.ZoomFactor = zoomPct / 100.0;
                }
            }
            catch { }

            this.Padding = new Padding(0);
            this.Invalidate();
            this.Update();
        }
        private async void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (webView21.IsDisposed || !e.IsSuccess) return;

            webView21.Visible = true;
            lastConnectionStatus = true;

            string fontFamily = Properties.Settings.Default.FontFamily;

            string fontStyle = !string.IsNullOrWhiteSpace(fontFamily) && fontFamily != "Basic"
                ? $"font-family: '{fontFamily}', sans-serif !important; font-weight: 400 !important;"
                : "";

            double alpha = backgroundOpacityPct / 100.0;
            string alphaStr = alpha.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);

            string js = $@"
        (function() {{
            let style = document.getElementById('chat-custom-style');
            if (!style) {{
                style = document.createElement('style');
                style.id = 'chat-custom-style';
                document.head.appendChild(style);
            }}
            style.innerHTML = `
                body {{ 
                    background-color: rgba(0,0,0,{alphaStr}) !important; 
                    margin: 0 !important; 
                    overflow: hidden !important; 
                }}
                
                .message_content, 
                .username, 
                .chat_line span:not([class*='badge']):not([class*='icon']) {{ 
                    {fontStyle}
                    -webkit-font-smoothing: antialiased;
                }}

                .badge-container, .chat-badge, [class*='badge'] {{
                    display: inline-block !important;
                    vertical-align: middle !important;
                }}
            `;
            
            if (!window.reconnectHandlersSet) {{
                window.addEventListener('online', () => location.reload());
                window.reconnectHandlersSet = true;
            }}
        }})();
    ";

            await webView21.ExecuteScriptAsync(js);
        }
        private void Form2_MoveResize(object sender, EventArgs e)
        {
            if (showBorder && isLoaded)
            {
                Properties.Settings.Default.ChatBoxBounds = $"{this.Location.X},{this.Location.Y},{this.Width},{this.Height}";
                Properties.Settings.Default.Save();
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionCheckTimer?.Stop();
            NetworkChange.NetworkAddressChanged -= OnNetworkAddressChanged;
            Properties.Settings.Default.ChatBoxBounds = $"{this.Location.X},{this.Location.Y},{this.Width},{this.Height}";
            Properties.Settings.Default.Save();
        }

        public void ApplyZoom(int zoom)
        {
            zoomPct = zoom;

            if (webView21 != null && !webView21.IsDisposed)
            {
                try
                {
                    webView21.ZoomFactor = zoomPct / 100.0;
                }
                catch { }
            }
        }
        public void ApplyBorder(bool border)
        {
            showBorder = border;

            if (!IsHandleCreated)
                return;

            Rectangle currentBounds = this.Bounds;

            this.SuspendLayout();

            if (border)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                this.Padding = new Padding(0);
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                this.Padding = new Padding(0);
            }

            this.Bounds = currentBounds;

            int exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle);

            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0,
                SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);

            this.ResumeLayout();
            this.Invalidate();
            this.Update();
        }

        public void LoadChatUrl(string url)
        {
            chatUrl = url;

            if (webView21 != null && !webView21.IsDisposed)
            {
                try
                {
                    if (webView21.Source != null && webView21.Source.ToString() == url)
                    {
                        webView21.Reload();
                    }
                    else
                    {
                        webView21.Source = new Uri(chatUrl);
                    }
                }
                catch { }
            }
        }
    }
}