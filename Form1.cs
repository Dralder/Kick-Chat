using System.Security.Policy;
using System;
using System.Windows.Forms;

namespace Kick_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private Form2 chatForm;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.Username;
            chkAnimate.Checked = Properties.Settings.Default.Animate;
            chkBadges.Checked = Properties.Settings.Default.Badges;
            chkCommands.Checked = Properties.Settings.Default.Commands;
            chkBots.Checked = Properties.Settings.Default.Bots;
            chkBorder.Checked = Properties.Settings.Default.Border;
            nudZoom.Value = Properties.Settings.Default.ZoomPct;

            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
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
            Properties.Settings.Default.Save();

            OpenForm2();
        }

        private void OpenForm2()
        {
            if (chatForm != null && !chatForm.IsDisposed)
            {
                chatForm.Close();
                chatForm.Dispose();
            }

            string url =
                "https://kick-chat.corard.tv/v1/chat?" +
                "user=" + txtUsername.Text +
                "&font-size=Medium" +
                "&stroke=Off" +
                "&animate=" + chkAnimate.Checked.ToString().ToLower() +
                "&fade=30" +
                "&badges=" + chkBadges.Checked.ToString().ToLower() +
                "&commands=" + chkCommands.Checked.ToString().ToLower() +
                "&bots=" + chkBots.Checked.ToString().ToLower();

            chatForm = new Form2(url, chkBorder.Checked, (int)nudZoom.Value);
            chatForm.Show();
        }
    }
}
