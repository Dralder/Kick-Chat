namespace Kick_Chat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUsername = new TextBox();
            chkAnimate = new CheckBox();
            chkBadges = new CheckBox();
            chkBots = new CheckBox();
            chkCommands = new CheckBox();
            btnSave = new Button();
            chkBorder = new CheckBox();
            nudZoom = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTwitchUser = new TextBox();
            label5 = new Label();
            nudFade = new NumericUpDown();
            cmbStroke = new ComboBox();
            label6 = new Label();
            fontlable = new Label();
            cmbFontSize = new ComboBox();
            label7 = new Label();
            cmbFontFamily = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFade).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(50, 50, 50);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtUsername.Location = new Point(12, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(170, 22);
            txtUsername.TabIndex = 0;
            // 
            // chkAnimate
            // 
            chkAnimate.AutoSize = true;
            chkAnimate.Checked = true;
            chkAnimate.CheckState = CheckState.Checked;
            chkAnimate.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAnimate.ForeColor = Color.WhiteSmoke;
            chkAnimate.Location = new Point(12, 65);
            chkAnimate.Name = "chkAnimate";
            chkAnimate.Size = new Size(85, 20);
            chkAnimate.TabIndex = 1;
            chkAnimate.Text = "Animate";
            chkAnimate.UseVisualStyleBackColor = true;
            // 
            // chkBadges
            // 
            chkBadges.AutoSize = true;
            chkBadges.Checked = true;
            chkBadges.CheckState = CheckState.Checked;
            chkBadges.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkBadges.ForeColor = Color.WhiteSmoke;
            chkBadges.Location = new Point(138, 65);
            chkBadges.Name = "chkBadges";
            chkBadges.Size = new Size(76, 20);
            chkBadges.TabIndex = 2;
            chkBadges.Text = "Badges";
            chkBadges.UseVisualStyleBackColor = true;
            // 
            // chkBots
            // 
            chkBots.AutoSize = true;
            chkBots.Checked = true;
            chkBots.CheckState = CheckState.Checked;
            chkBots.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkBots.ForeColor = Color.WhiteSmoke;
            chkBots.Location = new Point(138, 96);
            chkBots.Name = "chkBots";
            chkBots.Size = new Size(57, 20);
            chkBots.TabIndex = 3;
            chkBots.Text = "Bots";
            chkBots.UseVisualStyleBackColor = true;
            // 
            // chkCommands
            // 
            chkCommands.AutoSize = true;
            chkCommands.Checked = true;
            chkCommands.CheckState = CheckState.Checked;
            chkCommands.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkCommands.ForeColor = Color.WhiteSmoke;
            chkCommands.Location = new Point(12, 96);
            chkCommands.Name = "chkCommands";
            chkCommands.Size = new Size(105, 20);
            chkCommands.TabIndex = 4;
            chkCommands.Text = "Commands";
            chkCommands.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(299, 211);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 32);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // chkBorder
            // 
            chkBorder.AutoSize = true;
            chkBorder.Checked = true;
            chkBorder.CheckState = CheckState.Checked;
            chkBorder.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkBorder.ForeColor = Color.WhiteSmoke;
            chkBorder.Location = new Point(265, 65);
            chkBorder.Name = "chkBorder";
            chkBorder.Size = new Size(72, 20);
            chkBorder.TabIndex = 6;
            chkBorder.Text = "Border";
            chkBorder.UseVisualStyleBackColor = true;
            // 
            // nudZoom
            // 
            nudZoom.BackColor = Color.FromArgb(50, 50, 50);
            nudZoom.BorderStyle = BorderStyle.None;
            nudZoom.Font = new Font("Nirmala UI", 12F);
            nudZoom.ForeColor = Color.WhiteSmoke;
            nudZoom.Location = new Point(12, 218);
            nudZoom.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudZoom.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudZoom.Name = "nudZoom";
            nudZoom.Size = new Size(120, 25);
            nudZoom.TabIndex = 7;
            nudZoom.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 8;
            label1.Text = "Kick Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 199);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 9;
            label2.Text = "Zoom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala Text", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(11, 257);
            label3.Name = "label3";
            label3.Size = new Size(129, 13);
            label3.TabIndex = 10;
            label3.Text = "By Dralder - Late 2025  v";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(216, 8);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 12;
            label4.Text = "Twitch Username:";
            // 
            // txtTwitchUser
            // 
            txtTwitchUser.BackColor = Color.FromArgb(50, 50, 50);
            txtTwitchUser.BorderStyle = BorderStyle.None;
            txtTwitchUser.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTwitchUser.ForeColor = Color.WhiteSmoke;
            txtTwitchUser.Location = new Point(216, 32);
            txtTwitchUser.Name = "txtTwitchUser";
            txtTwitchUser.Size = new Size(170, 22);
            txtTwitchUser.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(149, 199);
            label5.Name = "label5";
            label5.Size = new Size(114, 16);
            label5.TabIndex = 14;
            label5.Text = "Fade (seconds)";
            // 
            // nudFade
            // 
            nudFade.BackColor = Color.FromArgb(50, 50, 50);
            nudFade.BorderStyle = BorderStyle.None;
            nudFade.Font = new Font("Nirmala UI", 12F);
            nudFade.ForeColor = Color.WhiteSmoke;
            nudFade.Location = new Point(149, 218);
            nudFade.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudFade.Name = "nudFade";
            nudFade.Size = new Size(120, 25);
            nudFade.TabIndex = 16;
            // 
            // cmbStroke
            // 
            cmbStroke.BackColor = Color.FromArgb(50, 50, 50);
            cmbStroke.FlatStyle = FlatStyle.Flat;
            cmbStroke.Font = new Font("Nirmala UI", 12F);
            cmbStroke.ForeColor = Color.WhiteSmoke;
            cmbStroke.FormattingEnabled = true;
            cmbStroke.Items.AddRange(new object[] { "Off", "Thin", "Medium", "Thick", "Thicker" });
            cmbStroke.Location = new Point(265, 148);
            cmbStroke.Name = "cmbStroke";
            cmbStroke.Size = new Size(121, 29);
            cmbStroke.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(265, 129);
            label6.Name = "label6";
            label6.Size = new Size(53, 16);
            label6.TabIndex = 18;
            label6.Text = "Stroke";
            // 
            // fontlable
            // 
            fontlable.AutoSize = true;
            fontlable.BackColor = Color.Transparent;
            fontlable.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            fontlable.ForeColor = Color.WhiteSmoke;
            fontlable.Location = new Point(138, 129);
            fontlable.Name = "fontlable";
            fontlable.Size = new Size(73, 16);
            fontlable.TabIndex = 20;
            fontlable.Text = "Font Size";
            // 
            // cmbFontSize
            // 
            cmbFontSize.BackColor = Color.FromArgb(50, 50, 50);
            cmbFontSize.FlatStyle = FlatStyle.Flat;
            cmbFontSize.Font = new Font("Nirmala UI", 12F);
            cmbFontSize.ForeColor = Color.WhiteSmoke;
            cmbFontSize.FormattingEnabled = true;
            cmbFontSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cmbFontSize.Location = new Point(138, 148);
            cmbFontSize.Name = "cmbFontSize";
            cmbFontSize.Size = new Size(121, 29);
            cmbFontSize.TabIndex = 19;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("MV Boli", 12F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(12, 119);
            label7.Name = "label7";
            label7.Size = new Size(121, 26);
            label7.TabIndex = 22;
            label7.Text = "Select Font";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbFontFamily
            // 
            cmbFontFamily.BackColor = Color.FromArgb(50, 50, 50);
            cmbFontFamily.FlatStyle = FlatStyle.Flat;
            cmbFontFamily.Font = new Font("Nirmala UI", 12F);
            cmbFontFamily.ForeColor = Color.WhiteSmoke;
            cmbFontFamily.FormattingEnabled = true;
            cmbFontFamily.Items.AddRange(new object[] { "Basic", "Arial", "Calibri", "Cambria", "Candara", "Consolas", "Corbel", "Century Gothic", "Franklin Gothic Heavy", "Franklin Gothic Medium", "Impact", "Lucida Sans Unicode", "Segoe UI", "Segoe UI Semibold", "Tahoma", "Trebuchet MS", "Verdana" });
            cmbFontFamily.Location = new Point(11, 148);
            cmbFontFamily.Name = "cmbFontFamily";
            cmbFontFamily.Size = new Size(121, 29);
            cmbFontFamily.TabIndex = 21;
            cmbFontFamily.SelectedIndexChanged += cmbFontFamily_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 19);
            ClientSize = new Size(397, 279);
            Controls.Add(label7);
            Controls.Add(cmbFontFamily);
            Controls.Add(fontlable);
            Controls.Add(cmbFontSize);
            Controls.Add(label6);
            Controls.Add(cmbStroke);
            Controls.Add(nudFade);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTwitchUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudZoom);
            Controls.Add(chkBorder);
            Controls.Add(btnSave);
            Controls.Add(chkCommands);
            Controls.Add(chkBots);
            Controls.Add(chkBadges);
            Controls.Add(chkAnimate);
            Controls.Add(txtUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Kick Chat";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudZoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private CheckBox chkAnimate;
        private CheckBox chkBadges;
        private CheckBox chkBots;
        private CheckBox chkCommands;
        private Button btnSave;
        private CheckBox chkBorder;
        private NumericUpDown nudZoom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTwitchUser;
        private Label label5;
        private NumericUpDown nudFade;
        private ComboBox cmbStroke;
        private Label label6;
        private Label fontlable;
        private ComboBox cmbFontSize;
        private Label label7;
        private ComboBox cmbFontFamily;
    }
}
