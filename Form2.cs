using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;

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

        public Form2(string url, bool border, int zoom)
        {
            InitializeComponent();
            chatUrl = url;
            showBorder = border;
            zoomPct = zoom;

            Load += Form2_Load;
            FormClosing += Form2_FormClosing;
            Move += Form2_MoveResize;
            ResizeEnd += Form2_MoveResize;

            NetworkChange.NetworkAddressChanged += OnNetworkAddressChanged;

            connectionCheckTimer = new System.Windows.Forms.Timer();
            connectionCheckTimer.Interval = 3000;
            connectionCheckTimer.Tick += ConnectionCheckTimer_Tick;
            connectionCheckTimer.Start();
        }

        private async void ConnectionCheckTimer_Tick(object sender, EventArgs e)
        {
            if (isReconnecting) return;

            bool currentStatus = await CheckInternetAccess();

            if (currentStatus && !lastConnectionStatus)
            {
                ReloadWebView();
            }
            else if (currentStatus && !webView21.Visible)
            {
                ReloadWebView();
            }

            lastConnectionStatus = currentStatus;
        }

        private async Task<bool> CheckInternetAccess()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
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

            await Task.Delay(1500);
            ReloadWebView();
            isReconnecting = false;
        }

        private void ReloadWebView()
        {
            if (!this.IsDisposed && webView21 != null)
            {
                this.BeginInvoke(new Action(() =>
                {
                    try { webView21.Reload(); } catch { }
                }));
            }
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = showBorder ? FormBorderStyle.Sizable : FormBorderStyle.None;
            BackColor = Color.Lime;
            TransparencyKey = Color.Lime;
            TopMost = true;
            ShowInTaskbar = false;

            if (firstLoad)
            {
                Location = new Point(Properties.Settings.Default.Form2X, Properties.Settings.Default.Form2Y);
                Size = new Size(Properties.Settings.Default.Form2Width, Properties.Settings.Default.Form2Height);
                firstLoad = false;
            }

            int exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            if (showBorder)
                SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle & ~WS_EX_TRANSPARENT);
            else
                SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle | WS_EX_LAYERED | WS_EX_TRANSPARENT);

            isLoaded = true;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);

            try
            {
                if (webView21 != null && !webView21.IsDisposed)
                {
                    if (webView21.CoreWebView2 == null)
                        await webView21.EnsureCoreWebView2Async();

                    webView21.NavigationStarting += (s, args) => { webView21.Visible = false; };
                    webView21.NavigationCompleted += WebView21_NavigationCompleted;

                    webView21.Source = new Uri(chatUrl);
                    webView21.ZoomFactor = zoomPct / 100.0;
                }
            }
            catch { }
        }

        private async void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (webView21.IsDisposed) return;

            if (!e.IsSuccess)
            {
                webView21.Visible = false;
                lastConnectionStatus = false;
                return;
            }

            webView21.Visible = true;
            lastConnectionStatus = true;

            string fontFamily = Properties.Settings.Default.FontFamily;
            string css = "";
            if (!string.IsNullOrWhiteSpace(fontFamily) && fontFamily != "Basic")
            {
                css = $@"body, #chat-container, .chat_line, .user_info, .username, .message_content {{ font-family: '{fontFamily}', 'Segoe UI', Arial, sans-serif !important; font-weight: 400 !important; }}";
            }

            string js = $@"
                if (!window.reconnectHandlersSet) {{
                    window.addEventListener('online', () => location.reload());
                    window.reconnectHandlersSet = true;
                }}
                {(string.IsNullOrEmpty(css) ? "" : $"let s = document.createElement('style'); s.innerHTML = `{css}`; document.head.appendChild(s);")}";

            await webView21.ExecuteScriptAsync(js);
        }

        private void Form2_MoveResize(object sender, EventArgs e)
        {
            if (showBorder && isLoaded)
            {
                Properties.Settings.Default.Form2X = Location.X;
                Properties.Settings.Default.Form2Y = Location.Y;
                Properties.Settings.Default.Form2Width = Size.Width;
                Properties.Settings.Default.Form2Height = Size.Height;
                Properties.Settings.Default.Save();
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionCheckTimer?.Stop();
            NetworkChange.NetworkAddressChanged -= OnNetworkAddressChanged;
            Properties.Settings.Default.Form2X = Location.X;
            Properties.Settings.Default.Form2Y = Location.Y;
            Properties.Settings.Default.Form2Width = Size.Width;
            Properties.Settings.Default.Form2Height = Size.Height;
            Properties.Settings.Default.Save();
        }

        private void webView21_Click(object sender, EventArgs e) { }
    }
}