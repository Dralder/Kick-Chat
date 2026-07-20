using ReaLTaiizor.Controls;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Kick_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            nudZoom.ValueChanged += nudZoom_ValueChanged;

            chkBorder.CheckedChanged += () =>
            {
                if (isInitializing) return;

                Properties.Settings.Default.Border = chkBorder.Checked;
                Properties.Settings.Default.Save();
                ApplyLiveOverlaySettings();
            };

            sliderBackground.Scroll += sliderBackground_Scroll;
            sliderBackground.MouseUp += (s, e) => { SaveBackgroundOpacity(); };

            obsTimer = new System.Windows.Forms.Timer();
            obsTimer.Interval = 3000;
            obsTimer.Tick += async (s, e) => await CheckObsStatusAsync();
            obsTimer.Start();

            txtcustom.TextChanged += txtcustom_TextChanged;
        }
        private bool isInitializingStatus = true;
        private bool obsLastTriggered = false;
        private DateTime? obsLastOfflineTime = null;
        private System.Windows.Forms.Timer obsTimer;
        private static readonly HttpClient httpClient = new HttpClient();

        private Form2 chatForm;
        private Rectangle lastBounds;
        private bool versionAppended = false;
        private bool isInitializing = false;
        private string? AttachedFile;
        private readonly string configPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Dralder", "kick_chat.json");
        private void EnsureConfigFolder()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(configPath));
        }
        private string EncryptString(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return string.Empty;
            try
            {
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] encryptedBytes = ProtectedData.Protect(plainBytes, null, DataProtectionScope.CurrentUser);
                return Convert.ToBase64String(encryptedBytes);
            }
            catch
            {
                return string.Empty;
            }
        }

        private string DecryptString(string encryptedText)
        {
            if (string.IsNullOrEmpty(encryptedText)) return string.Empty;
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.CurrentUser);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
            catch
            {
                return string.Empty;
            }
        }
        public class AppConfig
        {
            public string Username { get; set; }
            public bool TwitchEnabled { get; set; }
            public string TwitchUser { get; set; }
            public bool Animate { get; set; }
            public bool Badges { get; set; }
            public bool Commands { get; set; }
            public bool Bots { get; set; }
            public bool Border { get; set; }
            public int ZoomPct { get; set; }
            public string FontSize { get; set; }
            public string Stroke { get; set; }
            public int Fade { get; set; }
            public string FontFamily { get; set; }
            public int BGOpacity { get; set; }

            public bool Tele { get; set; }
            public bool Disc { get; set; }
            public string AlertMessage { get; set; }
            public string AttachedMedia { get; set; }
            public string bottoken { get; set; }
            public string channelid { get; set; }
            public string webhook { get; set; }
            public string OBShost { get; set; }
            public string OBSport { get; set; }
            public string OBSpassword { get; set; }
            public bool CustomCheck { get; set; }
            public string CustomURL { get; set; }
            public string ChatBoxBounds { get; set; }
            public string MainWindowBounds { get; set; }

        }
        private void LoadConfigFile()
        {
            EnsureConfigFolder();

            if (!File.Exists(configPath))
            {
                SaveConfigFile();
                return;
            }

            var json = File.ReadAllText(configPath);
            var config = System.Text.Json.JsonSerializer.Deserialize<AppConfig>(json);

            if (config == null) return;

            Properties.Settings.Default.Username = config.Username;
            Properties.Settings.Default.Animate = config.Animate;
            Properties.Settings.Default.Badges = config.Badges;
            Properties.Settings.Default.Commands = config.Commands;
            Properties.Settings.Default.Bots = config.Bots;
            Properties.Settings.Default.Border = config.Border;
            Properties.Settings.Default.ZoomPct = config.ZoomPct;
            Properties.Settings.Default.FontSize = config.FontSize;
            Properties.Settings.Default.Stroke = config.Stroke;
            Properties.Settings.Default.Fade = config.Fade;
            Properties.Settings.Default.FontFamily = config.FontFamily;
            Properties.Settings.Default.BGOpacity = config.BGOpacity;

            Properties.Settings.Default.Tele = config.Tele;
            Properties.Settings.Default.Disc = config.Disc;
            Properties.Settings.Default.AlertMessage = config.AlertMessage;
            Properties.Settings.Default.AttachedMedia = config.AttachedMedia;
            Properties.Settings.Default.bottoken = DecryptString(config.bottoken);
            Properties.Settings.Default.channelid = config.channelid;
            Properties.Settings.Default.webhook = DecryptString(config.webhook);
            Properties.Settings.Default.OBShost = config.OBShost;
            Properties.Settings.Default.OBSport = config.OBSport;
            Properties.Settings.Default.OBSpassword = DecryptString(config.OBSpassword);

            Properties.Settings.Default.TwitchEnabled = config.TwitchEnabled;
            Properties.Settings.Default.TwitchUser = config.TwitchUser;

            Properties.Settings.Default.CustomCheck = config.CustomCheck;
            Properties.Settings.Default.CustomURL = config.CustomURL;

            Properties.Settings.Default.ChatBoxBounds = config.ChatBoxBounds;
            Properties.Settings.Default.MainWindowBounds = config.MainWindowBounds;

            Properties.Settings.Default.Save();
        }
        private void SaveConfigFile()
        {
            EnsureConfigFolder();

            var config = new AppConfig
            {
                Username = txtUsername.Text,
                Animate = chkAnimate.Checked,
                Badges = chkBadges.Checked,
                Commands = chkCommands.Checked,
                Bots = chkBots.Checked,
                Border = chkBorder.Checked,
                ZoomPct = (int)nudZoom.Value,
                FontSize = cmbFontSize.SelectedItem?.ToString() ?? "Medium",
                Stroke = cmbStroke.SelectedItem?.ToString() ?? "Off",
                Fade = (int)nudFade.Value,
                FontFamily = cmbFontFamily.SelectedItem?.ToString() ?? "Basic",
                BGOpacity = sliderBackground.Percentage,

                Tele = telegramCheckBox.Checked,
                Disc = discordCheckBox.Checked,
                AlertMessage = AlertMessageRTB.Text,
                AttachedMedia = AttachedFile,
                bottoken = EncryptString(tokenTB.Text.Trim()),
                channelid = channelTB.Text.Trim(),
                webhook = EncryptString(webhookTB.Text.Trim()),
                OBShost = obshostTB.Text.Trim(),
                OBSport = obsportTB.Text.Trim(),
                OBSpassword = EncryptString(obspassTB.Text),

                TwitchEnabled = twitchCheckBox.Checked,
                TwitchUser = twitchTB.Text.Trim(),

                CustomCheck = chkCustom.Checked,
                CustomURL = txtcustom.Text.Trim(),

                ChatBoxBounds = chatForm != null && !chatForm.IsDisposed
                    ? $"{chatForm.Location.X},{chatForm.Location.Y},{chatForm.Width},{chatForm.Height}"
                    : Properties.Settings.Default.ChatBoxBounds,

                MainWindowBounds = this.WindowState == FormWindowState.Normal
                    ? $"{this.Location.X},{this.Location.Y},{this.Width},{this.Height}"
                    : Properties.Settings.Default.MainWindowBounds
            };

            File.WriteAllText(configPath,
                System.Text.Json.JsonSerializer.Serialize(config, new System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = true
                }));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            isInitializing = true;
            LoadConfigFile();

            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            string shortVersion = $"{ver.Major}.{ver.Minor}.{ver.Build}";
            label3.Text += "" + shortVersion;
            versionAppended = true;

            txtUsername.Text = Properties.Settings.Default.Username;
            chkAnimate.Checked = Properties.Settings.Default.Animate;
            chkBadges.Checked = Properties.Settings.Default.Badges;
            chkCommands.Checked = Properties.Settings.Default.Commands;
            chkBots.Checked = Properties.Settings.Default.Bots;
            chkBorder.Checked = Properties.Settings.Default.Border;
            nudZoom.Value = Properties.Settings.Default.ZoomPct;
            cmbFontSize.SelectedItem = Properties.Settings.Default.FontSize;
            cmbStroke.SelectedItem = Properties.Settings.Default.Stroke;
            nudFade.Value = Properties.Settings.Default.Fade;
            cmbFontFamily.SelectedItem = Properties.Settings.Default.FontFamily;
            sliderBackground.Percentage = Properties.Settings.Default.BGOpacity;

            telegramCheckBox.Checked = Properties.Settings.Default.Tele;
            discordCheckBox.Checked = Properties.Settings.Default.Disc;
            AlertMessageRTB.Text = Properties.Settings.Default.AlertMessage;
            AttachedFile = Properties.Settings.Default.AttachedMedia;
            tokenTB.Text = Properties.Settings.Default.bottoken;
            channelTB.Text = Properties.Settings.Default.channelid;
            webhookTB.Text = Properties.Settings.Default.webhook;
            obshostTB.Text = Properties.Settings.Default.OBShost;
            obsportTB.Text = Properties.Settings.Default.OBSport;
            obspassTB.Text = Properties.Settings.Default.OBSpassword;

            twitchCheckBox.Checked = Properties.Settings.Default.TwitchEnabled;
            twitchTB.Text = Properties.Settings.Default.TwitchUser;

            chkCustom.Checked = Properties.Settings.Default.CustomCheck;
            txtcustom.Text = Properties.Settings.Default.CustomURL;
            txtcustom.Enabled = chkCustom.Checked;

            string selectedFont = Properties.Settings.Default.FontFamily ?? "Basic";
            if (selectedFont == "Basic")
            {
                label7.Font = new Font("Arial Black", label7.Font.Size, label7.Font.Style);
            }
            else
            {
                label7.Font = new Font(selectedFont, label7.Font.Size, label7.Font.Style);
            }

            if (!string.IsNullOrWhiteSpace(AttachedFile) && File.Exists(AttachedFile))
            {
                pictureBox1.Image = Image.FromFile(AttachedFile);
            }

            isInitializing = false;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.MainWindowBounds))
            {
                try
                {
                    string[] parts = Properties.Settings.Default.MainWindowBounds.Split(',');
                    if (parts.Length == 4)
                    {
                        this.StartPosition = FormStartPosition.Manual;
                        this.Location = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                        this.Size = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                }
                catch { }
            }

            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                OpenForm2();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAll();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                chatForm?.Close();
                chatForm = null;
                return;
            }

            if (chatForm != null && !chatForm.IsDisposed)
            {
                chatForm.ApplyBorder(chkBorder.Checked);
                chatForm.ApplyZoom((int)nudZoom.Value);
                chatForm.UpdateOpacity(sliderBackground.Percentage);
                chatForm.LoadChatUrl(BuildChatUrl());
            }
            else
            {
                OpenForm2();
            }
        }
        private void OpenForm2()
        {
            string url = BuildChatUrl();

            if (chatForm != null && !chatForm.IsDisposed)
            {
                chatForm.LoadChatUrl(url);
                chatForm.ApplyBorder(chkBorder.Checked);
                chatForm.ApplyZoom((int)nudZoom.Value);
                chatForm.UpdateOpacity(sliderBackground.Percentage);
                return;
            }

            chatForm = new Form2(url, chkBorder.Checked, (int)nudZoom.Value);

            if (!string.IsNullOrEmpty(Properties.Settings.Default.ChatBoxBounds))
            {
                try
                {
                    string[] parts = Properties.Settings.Default.ChatBoxBounds.Split(',');
                    if (parts.Length == 4)
                    {
                        chatForm.StartPosition = FormStartPosition.Manual;
                        chatForm.Location = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                        chatForm.Size = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                }
                catch { }
            }
            chatForm.Show();
        }
        private void cmbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FontFamily = cmbFontFamily.SelectedItem?.ToString() ?? "Basic";

            string selectedFont = cmbFontFamily.SelectedItem?.ToString() ?? "Basic";
            if (selectedFont == "Basic")
            {
                label7.Font = new Font("Arial Black", label7.Font.Size, label7.Font.Style);
            }
            else
            {
                label7.Font = new Font(selectedFont, label7.Font.Size, label7.Font.Style);
            }
        }
        private void parrotSlider1_Scroll(object sender, EventArgs e)
        {
            if (isInitializing) return;
            ApplyLiveOverlaySettings();
        }

        private string BuildChatUrl()
        {
            if (chkCustom.Checked)
            {
                string custom = txtcustom.Text.Trim();

                if (!string.IsNullOrWhiteSpace(custom))
                {
                    if (!custom.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                        !custom.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                    {
                        custom = "https://" + custom;
                    }

                    return custom;
                }
            }

            string url = "https://kick-chat.corard.tv/v1/chat?";

            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
                url += "user=" + txtUsername.Text;

            if (twitchCheckBox.Checked && !string.IsNullOrWhiteSpace(twitchTB.Text))
                url += "&twitchuser=" + twitchTB.Text.Trim();

            url += "&font-size=" + (cmbFontSize.SelectedItem?.ToString() ?? "Medium") +
                   "&stroke=" + (cmbStroke.SelectedItem?.ToString() ?? "Off") +
                   "&animate=" + chkAnimate.Checked.ToString().ToLower();

            if (nudFade.Value > 0)
                url += "&fade=" + nudFade.Value;

            url += "&badges=" + chkBadges.Checked.ToString().ToLower() +
                   "&commands=" + chkCommands.Checked.ToString().ToLower() +
                   "&bots=" + chkBots.Checked.ToString().ToLower();

            return url;
        }

        private void nudZoom_ValueChanged(object sender, EventArgs e)
        {
            if (isInitializing)
                return;

            Properties.Settings.Default.ZoomPct = (int)nudZoom.Value;
            Properties.Settings.Default.Save();
            ApplyLiveOverlaySettings();
        }

        private void sliderBackground_Scroll(object sender, EventArgs e)
        {
            if (isInitializing) return;
            ApplyLiveOverlaySettings();
        }
        private void SaveBackgroundOpacity()
        {
            if (isInitializing) return;
            Properties.Settings.Default.BGOpacity = sliderBackground.Percentage;
            Properties.Settings.Default.Save();
        }
        private void ApplyLiveOverlaySettings()
        {
            if (chatForm != null && !chatForm.IsDisposed)
            {
                chatForm.ApplyBorder(chkBorder.Checked);
                chatForm.ApplyZoom((int)nudZoom.Value);
                chatForm.UpdateOpacity(sliderBackground.Percentage);
            }
        }

        private void btnpanel_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                btnpanel.ButtonText = "> Chat <";
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = false;
                btnpanel.ButtonText = "> Alerts <";
            }
        }

        private void telegramCheckBox_CheckedChanged()
        {
            if (telegramCheckBox.Checked == true)
            {
                tokenTB.Enabled = true;
                channelTB.Enabled = true;
            }
            else
            {
                tokenTB.Enabled = false;
                channelTB.Enabled = false;
            }
            Properties.Settings.Default.Tele = telegramCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void discordCheckBox_CheckedChanged()
        {
            if (discordCheckBox.Checked == true)
            {
                webhookTB.Enabled = true;
            }
            else
            {
                webhookTB.Enabled = false;
            }
            Properties.Settings.Default.Disc = discordCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void parrotButton2_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AttachedFile = dialog.FileName;

                pictureBox1.Image?.Dispose();
                pictureBox1.Image = Image.FromFile(AttachedFile);
            }
        }
        private async Task<bool> ProbeObsPortAsync(string host, string port)
        {
            if (!int.TryParse(port, out int portNum))
            {
                foreverLabel1.ForeColor = Color.Red;
                return false;
            }
            try
            {
                foreverLabel1.ForeColor = Color.Yellow;
                using (var client = new System.Net.Sockets.TcpClient())
                {
                    var connectTask = client.ConnectAsync(host, portNum);
                    if (await Task.WhenAny(connectTask, Task.Delay(1500)) == connectTask)
                    {
                        if (client.Connected)
                        {
                            foreverLabel1.ForeColor = Color.FromArgb(83, 253, 25);
                            return true;
                        }
                    }
                    foreverLabel1.ForeColor = Color.Red;
                    return false;
                }
            }
            catch
            {
                foreverLabel1.ForeColor = Color.Red;
                return false;
            }
        }
        private async Task CheckObsStatusAsync()
        {
            obsTimer.Stop();
            try
            {
                string host = obshostTB.Text.Trim();
                string port = obsportTB.Text.Trim();

                if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(port))
                {
                    foreverLabel1.ForeColor = Color.Red;
                    return;
                }

                bool isObsReachable = await ProbeObsPortAsync(host, port);

                bool triggered = false;

                if (isObsReachable)
                {
                    try
                    {
                        using (var client = new System.Net.WebSockets.ClientWebSocket())
                        {
                            foreverLabel1.ForeColor = Color.Yellow;

                            var uri = new Uri($"ws://{host}:{port}/");
                            using (var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(3)))
                            {
                                await client.ConnectAsync(uri, cts.Token);
                            }

                            foreverLabel1.ForeColor = Color.Lime;

                            var buffer = new byte[4096];
                            var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), System.Threading.CancellationToken.None);
                            string greetingJson = Encoding.UTF8.GetString(buffer, 0, result.Count);

                            var greeting = System.Text.Json.JsonDocument.Parse(greetingJson);

                            string authResponse = "{\"op\":1,\"d\":{\"rpcVersion\":1}}";
                            if (greeting.RootElement.GetProperty("d").TryGetProperty("authentication", out var authElement))
                            {
                                string challenge = authElement.GetProperty("challenge").GetString();
                                string salt = authElement.GetProperty("salt").GetString();
                                string password = obspassTB.Text;

                                string secretString = password + salt;
                                byte[] secretHashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(secretString));
                                string secretHashBase64 = Convert.ToBase64String(secretHashBytes);

                                string authString = secretHashBase64 + challenge;
                                byte[] authHashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(authString));
                                string authHashBase64 = Convert.ToBase64String(authHashBytes);

                                authResponse = "{\"op\":1,\"d\":{\"rpcVersion\":1,\"authentication\":\"" + authHashBase64 + "\"}}";
                            }

                            var authBytes = Encoding.UTF8.GetBytes(authResponse);
                            await client.SendAsync(new ArraySegment<byte>(authBytes), System.Net.WebSockets.WebSocketMessageType.Text, true, System.Threading.CancellationToken.None);

                            result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), System.Threading.CancellationToken.None);
                            string identResponse = Encoding.UTF8.GetString(buffer, 0, result.Count);

                            string getStreamStatusJson = "{\"op\":6,\"d\":{\"requestType\":\"GetStreamStatus\",\"requestId\":\"req-stream\"}}";
                            var streamBytes = Encoding.UTF8.GetBytes(getStreamStatusJson);
                            await client.SendAsync(new ArraySegment<byte>(streamBytes), System.Net.WebSockets.WebSocketMessageType.Text, true, System.Threading.CancellationToken.None);

                            result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), System.Threading.CancellationToken.None);
                            string streamStatusResp = Encoding.UTF8.GetString(buffer, 0, result.Count);
                            var streamDoc = System.Text.Json.JsonDocument.Parse(streamStatusResp);
                            bool isStreaming = streamDoc.RootElement.GetProperty("d").GetProperty("responseData").GetProperty("outputActive").GetBoolean();

                            string getRecordStatusJson = "{\"op\":6,\"d\":{\"requestType\":\"GetRecordStatus\",\"requestId\":\"req-record\"}}";
                            var recordBytes = Encoding.UTF8.GetBytes(getRecordStatusJson);
                            await client.SendAsync(new ArraySegment<byte>(recordBytes), System.Net.WebSockets.WebSocketMessageType.Text, true, System.Threading.CancellationToken.None);

                            result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), System.Threading.CancellationToken.None);
                            string recordStatusResp = Encoding.UTF8.GetString(buffer, 0, result.Count);
                            var recordDoc = System.Text.Json.JsonDocument.Parse(recordStatusResp);
                            bool isRecording = recordDoc.RootElement.GetProperty("d").GetProperty("responseData").GetProperty("outputActive").GetBoolean();

                            triggered = isStreaming || isRecording;

                            await client.CloseAsync(System.Net.WebSockets.WebSocketCloseStatus.NormalClosure, "Done", System.Threading.CancellationToken.None);
                        }
                    }
                    catch (Exception ex)
                    {
                        foreverLabel1.ForeColor = Color.Red;
                        triggered = false;
                    }
                }

                if (triggered)
                {
                    if (!obsLastTriggered || isInitializingStatus)
                    {
                        bool shouldAlert = false;
                        if (obsLastOfflineTime == null)
                        {
                            shouldAlert = true;
                        }
                        else
                        {
                            double minutesOffline = (DateTime.Now - obsLastOfflineTime.Value).TotalMinutes;
                            if (minutesOffline >= 1.0)
                            {
                                shouldAlert = true;
                            }
                        }

                        if (shouldAlert)
                        {
                            await SendAlertsAsync();
                        }
                    }
                }
                else
                {
                    if (obsLastTriggered && !isInitializingStatus)
                    {
                        obsLastOfflineTime = DateTime.Now;
                    }
                }

                obsLastTriggered = triggered;
                isInitializingStatus = false;
            }
            finally
            {
                obsTimer.Start();
            }
        }

        private async Task SendAlertsAsync()
        {
            string message = AlertMessageRTB.Text;
            bool hasFile = !string.IsNullOrWhiteSpace(AttachedFile) && File.Exists(AttachedFile);

            string streamUrl = string.Empty;
            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                streamUrl = $"https://kick.com/{txtUsername.Text.Trim()}";
            }

            if (telegramCheckBox.Checked && !string.IsNullOrWhiteSpace(tokenTB.Text) && !string.IsNullOrWhiteSpace(channelTB.Text))
            {
                try
                {
                    string telegramMessage = $"<b>🔴 LIVE</b>\n\n{message}";
                    if (!string.IsNullOrEmpty(streamUrl))
                    {
                        telegramMessage += $"\n\n<a href=\"{streamUrl}\"><b>Watch Now!</b></a>";
                    }

                    string token = tokenTB.Text.Trim();
                    string channel = channelTB.Text.Trim();

                    if (hasFile)
                    {
                        string ext = Path.GetExtension(AttachedFile).ToLower();
                        string method = "sendDocument";
                        string paramName = "document";

                        if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".webp") { method = "sendPhoto"; paramName = "photo"; }
                        else if (ext == ".gif") { method = "sendAnimation"; paramName = "animation"; }
                        else if (ext == ".mp4" || ext == ".mov" || ext == ".webm") { method = "sendVideo"; paramName = "video"; }

                        string url = $"https://api.telegram.org/bot{token}/{method}";

                        using (var form = new MultipartFormDataContent())
                        {
                            form.Add(new StringContent(channel), "chat_id");
                            form.Add(new StringContent(telegramMessage), "caption");
                            form.Add(new StringContent("HTML"), "parse_mode");

                            byte[] fileBytes = await File.ReadAllBytesAsync(AttachedFile);
                            var fileContent = new ByteArrayContent(fileBytes);

                            string mimeType = "application/octet-stream";
                            if (method == "sendPhoto") mimeType = "image/jpeg";
                            else if (method == "sendAnimation") mimeType = "image/gif";
                            else if (method == "sendVideo") mimeType = "video/mp4";

                            fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mimeType);
                            form.Add(fileContent, paramName, Path.GetFileName(AttachedFile));

                            await httpClient.PostAsync(url, form);
                        }
                    }
                    else
                    {
                        string url = $"https://api.telegram.org/bot{token}/sendMessage";
                        var payload = new Dictionary<string, string>
                {
                    { "chat_id", channel },
                    { "text", telegramMessage },
                    { "parse_mode", "HTML" }
                };
                        await httpClient.PostAsync(url, new FormUrlEncodedContent(payload));
                    }
                }
                catch { }
            }

            if (discordCheckBox.Checked && !string.IsNullOrWhiteSpace(webhookTB.Text))
            {
                try
                {
                    string discordDescription = message;
                    if (!string.IsNullOrEmpty(streamUrl))
                    {
                        discordDescription += $"\n\n[**Watch Now!**]({streamUrl})";
                    }

                    var embedObject = new
                    {
                        embeds = new[]
                        {
                    new
                    {
                        title = "🔴 LIVE!",
                        description = discordDescription,
                        url = !string.IsNullOrEmpty(streamUrl) ? streamUrl : null,
                        color = 5504024,
                        image = hasFile ? new { url = $"attachment://{Path.GetFileName(AttachedFile)}" } : null
                    }
                }
                    };

                    string jsonPayload = System.Text.Json.JsonSerializer.Serialize(embedObject);

                    if (hasFile)
                    {
                        using (var form = new MultipartFormDataContent())
                        {
                            form.Add(new StringContent(jsonPayload), "payload_json");

                            byte[] fileBytes = await File.ReadAllBytesAsync(AttachedFile);
                            var fileContent = new ByteArrayContent(fileBytes);
                            fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                            form.Add(fileContent, "file", Path.GetFileName(AttachedFile));

                            await httpClient.PostAsync(webhookTB.Text, form);
                        }
                    }
                    else
                    {
                        var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
                        await httpClient.PostAsync(webhookTB.Text, content);
                    }
                }
                catch { }
            }
        }

        private void parrotButton3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;
            AttachedFile = null;
        }
        private void SaveAll()
        {
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Animate = chkAnimate.Checked;
            Properties.Settings.Default.Badges = chkBadges.Checked;
            Properties.Settings.Default.Commands = chkCommands.Checked;
            Properties.Settings.Default.Bots = chkBots.Checked;
            Properties.Settings.Default.Border = chkBorder.Checked;
            Properties.Settings.Default.ZoomPct = (int)nudZoom.Value;
            Properties.Settings.Default.FontSize = cmbFontSize.SelectedItem?.ToString() ?? "Medium";
            Properties.Settings.Default.Stroke = cmbStroke.SelectedItem?.ToString() ?? "Off";
            Properties.Settings.Default.Fade = (int)nudFade.Value;
            Properties.Settings.Default.FontFamily = cmbFontFamily.SelectedItem?.ToString() ?? "Basic";
            Properties.Settings.Default.BGOpacity = sliderBackground.Percentage;

            Properties.Settings.Default.Tele = telegramCheckBox.Checked;
            Properties.Settings.Default.Disc = discordCheckBox.Checked;
            Properties.Settings.Default.AlertMessage = AlertMessageRTB.Text;
            Properties.Settings.Default.AttachedMedia = AttachedFile;
            Properties.Settings.Default.bottoken = tokenTB.Text.Trim();
            Properties.Settings.Default.webhook = webhookTB.Text.Trim();
            Properties.Settings.Default.channelid = channelTB.Text;
            Properties.Settings.Default.OBShost = obshostTB.Text;
            Properties.Settings.Default.OBSport = obsportTB.Text;
            Properties.Settings.Default.OBSpassword = obspassTB.Text;

            Properties.Settings.Default.TwitchEnabled = twitchCheckBox.Checked;
            Properties.Settings.Default.TwitchUser = twitchTB.Text;

            Properties.Settings.Default.CustomCheck = chkCustom.Checked;
            Properties.Settings.Default.CustomURL = txtcustom.Text.Trim();

            if (chatForm != null && !chatForm.IsDisposed)
            {
                Properties.Settings.Default.ChatBoxBounds = $"{chatForm.Location.X},{chatForm.Location.Y},{chatForm.Width},{chatForm.Height}";
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.MainWindowBounds = $"{this.Location.X},{this.Location.Y},{this.Width},{this.Height}";
            }
            Properties.Settings.Default.Save();
            SaveConfigFile();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAll();
        }

        private void twitchCheckBox_CheckedChanged()
        {
            twitchTB.Enabled = twitchCheckBox.Checked;
        }

        private void chkCustom_CheckedChanged()
        {
            txtcustom.Enabled = chkCustom.Checked;

            Properties.Settings.Default.CustomCheck = chkCustom.Checked;
            Properties.Settings.Default.Save();

            if (isInitializing)
                return;

            if (chatForm != null && !chatForm.IsDisposed)
                chatForm.LoadChatUrl(BuildChatUrl());
        }
        private void txtcustom_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing)
                return;

            Properties.Settings.Default.CustomURL = txtcustom.Text.Trim();
            Properties.Settings.Default.Save();

            if (chkCustom.Checked && chatForm != null && !chatForm.IsDisposed)
                chatForm.LoadChatUrl(BuildChatUrl());
        }
    }
}