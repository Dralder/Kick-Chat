using System;
using System.Reflection;
using System.Security.Policy;
using System.Windows.Forms;

namespace Kick_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 chatForm;
        private bool versionAppended = false;

        private void Form1_Load(object sender, EventArgs e)
        {
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
            txtTwitchUser.Text = Properties.Settings.Default.TwitchUser;
            cmbFontFamily.SelectedItem = Properties.Settings.Default.FontFamily;

            string selectedFont = Properties.Settings.Default.FontFamily ?? "Basic";
            if (selectedFont == "Basic")
            {
                label7.Font = new Font("Arial Black", label7.Font.Size, label7.Font.Style);
            }
            else
            {
                label7.Font = new Font(selectedFont, label7.Font.Size, label7.Font.Style);
            }

            if (!string.IsNullOrWhiteSpace(txtUsername.Text) || !string.IsNullOrWhiteSpace(txtTwitchUser.Text))
            {
                OpenForm2();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            Properties.Settings.Default.TwitchUser = txtTwitchUser.Text;
            Properties.Settings.Default.FontFamily = cmbFontFamily.SelectedItem?.ToString() ?? "Basic";
            Properties.Settings.Default.Save();

            if (!string.IsNullOrWhiteSpace(txtUsername.Text) || !string.IsNullOrWhiteSpace(txtTwitchUser.Text))
            {
                OpenForm2();
            }
            else
            {
                chatForm?.Close();
                chatForm = null;
            }
        }

        private void OpenForm2()
        {
            if (chatForm != null && !chatForm.IsDisposed)
            {
                chatForm.Close();
                chatForm.Dispose();
            }

            string url = "https://beta.kick-chat.corard.tv/v1/chat?";

            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
                url += "user=" + txtUsername.Text;

            url += "&font-size=" + (cmbFontSize.SelectedItem?.ToString() ?? "Medium") +
                   "&stroke=" + (cmbStroke.SelectedItem?.ToString() ?? "Off") +
                   "&animate=" + chkAnimate.Checked.ToString().ToLower();

            if (nudFade.Value > 0)
                url += "&fade=" + nudFade.Value;

            url += "&badges=" + chkBadges.Checked.ToString().ToLower() +
                   "&commands=" + chkCommands.Checked.ToString().ToLower() +
                   "&bots=" + chkBots.Checked.ToString().ToLower();

            if (!string.IsNullOrWhiteSpace(txtTwitchUser.Text))
                url += "&twitchuser=" + txtTwitchUser.Text;

            chatForm = new Form2(url, chkBorder.Checked, (int)nudZoom.Value);
            chatForm.Show();
        }



        private void cmbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
