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
            ((System.ComponentModel.ISupportInitialize)nudZoom).BeginInit();
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
            txtUsername.Size = new Size(154, 22);
            txtUsername.TabIndex = 0;
            // 
            // chkAnimate
            // 
            chkAnimate.AutoSize = true;
            chkAnimate.Checked = true;
            chkAnimate.CheckState = CheckState.Checked;
            chkAnimate.Font = new Font("MV Boli", 12F);
            chkAnimate.ForeColor = Color.WhiteSmoke;
            chkAnimate.Location = new Point(12, 65);
            chkAnimate.Name = "chkAnimate";
            chkAnimate.Size = new Size(91, 25);
            chkAnimate.TabIndex = 1;
            chkAnimate.Text = "Animate";
            chkAnimate.UseVisualStyleBackColor = true;
            // 
            // chkBadges
            // 
            chkBadges.AutoSize = true;
            chkBadges.Checked = true;
            chkBadges.CheckState = CheckState.Checked;
            chkBadges.Font = new Font("MV Boli", 12F);
            chkBadges.ForeColor = Color.WhiteSmoke;
            chkBadges.Location = new Point(148, 65);
            chkBadges.Name = "chkBadges";
            chkBadges.Size = new Size(79, 25);
            chkBadges.TabIndex = 2;
            chkBadges.Text = "Badges";
            chkBadges.UseVisualStyleBackColor = true;
            // 
            // chkBots
            // 
            chkBots.AutoSize = true;
            chkBots.Checked = true;
            chkBots.CheckState = CheckState.Checked;
            chkBots.Font = new Font("MV Boli", 12F);
            chkBots.ForeColor = Color.WhiteSmoke;
            chkBots.Location = new Point(148, 96);
            chkBots.Name = "chkBots";
            chkBots.Size = new Size(62, 25);
            chkBots.TabIndex = 3;
            chkBots.Text = "Bots";
            chkBots.UseVisualStyleBackColor = true;
            // 
            // chkCommands
            // 
            chkCommands.AutoSize = true;
            chkCommands.Checked = true;
            chkCommands.CheckState = CheckState.Checked;
            chkCommands.Font = new Font("MV Boli", 12F);
            chkCommands.ForeColor = Color.WhiteSmoke;
            chkCommands.Location = new Point(12, 96);
            chkCommands.Name = "chkCommands";
            chkCommands.Size = new Size(108, 25);
            chkCommands.TabIndex = 4;
            chkCommands.Text = "Commands";
            chkCommands.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(83, 253, 25);
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("MV Boli", 12F);
            btnSave.Location = new Point(148, 191);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 35);
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
            chkBorder.Font = new Font("MV Boli", 12F);
            chkBorder.ForeColor = Color.WhiteSmoke;
            chkBorder.Location = new Point(148, 160);
            chkBorder.Name = "chkBorder";
            chkBorder.Size = new Size(78, 25);
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
            nudZoom.Location = new Point(12, 160);
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
            label1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 8;
            label1.Text = "Kick Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 9;
            label2.Text = "Zoom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala Text", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(81, 26);
            label3.TabIndex = 10;
            label3.Text = "By Dralder\r\nLate 2025  v1.0\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 19);
            ClientSize = new Size(250, 235);
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
    }
}
