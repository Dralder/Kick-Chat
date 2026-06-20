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
            label1 = new Label();
            txtUsername = new ReaLTaiizor.Controls.CrownTextBox();
            panel1 = new Panel();
            sliderBackground = new ReaLTaiizor.Controls.ParrotSlider();
            label10 = new Label();
            twitchTB = new ReaLTaiizor.Controls.CrownTextBox();
            label4 = new Label();
            nudFade = new ReaLTaiizor.Controls.CrownNumeric();
            nudZoom = new ReaLTaiizor.Controls.CrownNumeric();
            chkBorder = new ReaLTaiizor.Controls.CyberCheckBox();
            cmbStroke = new ReaLTaiizor.Controls.ForeverComboBox();
            cmbFontSize = new ReaLTaiizor.Controls.ForeverComboBox();
            chkBots = new ReaLTaiizor.Controls.CyberCheckBox();
            chkCommands = new ReaLTaiizor.Controls.CyberCheckBox();
            chkBadges = new ReaLTaiizor.Controls.CyberCheckBox();
            cmbFontFamily = new ReaLTaiizor.Controls.ForeverComboBox();
            btnSave = new ReaLTaiizor.Controls.ParrotButton();
            chkAnimate = new ReaLTaiizor.Controls.CyberCheckBox();
            label7 = new Label();
            fontlable = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            twitchCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            label3 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            parrotButton3 = new ReaLTaiizor.Controls.ParrotButton();
            pictureBox1 = new PictureBox();
            parrotButton2 = new ReaLTaiizor.Controls.ParrotButton();
            AlertMessageRTB = new RichTextBox();
            foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            nightLabel6 = new ReaLTaiizor.Controls.NightLabel();
            obspassTB = new ReaLTaiizor.Controls.DreamTextBox();
            nightLabel5 = new ReaLTaiizor.Controls.NightLabel();
            obsportTB = new ReaLTaiizor.Controls.DreamTextBox();
            nightLabel4 = new ReaLTaiizor.Controls.NightLabel();
            obshostTB = new ReaLTaiizor.Controls.DreamTextBox();
            foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            label8 = new Label();
            nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            webhookTB = new ReaLTaiizor.Controls.DreamTextBox();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            channelTB = new ReaLTaiizor.Controls.DreamTextBox();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            tokenTB = new ReaLTaiizor.Controls.DreamTextBox();
            discordCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            telegramCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            btnpanel = new ReaLTaiizor.Controls.ParrotButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZoom).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 8;
            label1.Text = "Kick Username:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(24, 24, 24);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Nirmala UI", 12F);
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtUsername.Location = new Point(21, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(194, 29);
            txtUsername.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.Controls.Add(sliderBackground);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(twitchTB);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nudFade);
            panel1.Controls.Add(nudZoom);
            panel1.Controls.Add(chkBorder);
            panel1.Controls.Add(cmbStroke);
            panel1.Controls.Add(cmbFontSize);
            panel1.Controls.Add(chkBots);
            panel1.Controls.Add(chkCommands);
            panel1.Controls.Add(chkBadges);
            panel1.Controls.Add(cmbFontFamily);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(chkAnimate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(fontlable);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(twitchCheckBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 271);
            panel1.TabIndex = 56;
            // 
            // sliderBackground
            // 
            sliderBackground.BarThickness = 4;
            sliderBackground.BigStepIncrement = 10;
            sliderBackground.Colors = (List<Color>)resources.GetObject("sliderBackground.Colors");
            sliderBackground.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            sliderBackground.FilledColor = Color.FromArgb(76, 217, 100);
            sliderBackground.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            sliderBackground.KnobColor = Color.DimGray;
            sliderBackground.KnobImage = null;
            sliderBackground.Location = new Point(12, 106);
            sliderBackground.Max = 100;
            sliderBackground.Name = "sliderBackground";
            sliderBackground.Percentage = 50;
            sliderBackground.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            sliderBackground.Positions = (List<float>)resources.GetObject("sliderBackground.Positions");
            sliderBackground.QuickHopping = false;
            sliderBackground.Size = new Size(248, 20);
            sliderBackground.SliderStyle = ReaLTaiizor.Controls.ParrotSlider.Style.Android;
            sliderBackground.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            sliderBackground.TabIndex = 73;
            sliderBackground.Text = "parrotSlider1";
            sliderBackground.UnfilledColor = Color.FromArgb(76, 217, 100);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(247, 16);
            label10.Name = "label10";
            label10.Size = new Size(167, 20);
            label10.TabIndex = 77;
            label10.Text = "Twitch Username:";
            // 
            // twitchTB
            // 
            twitchTB.BackColor = Color.FromArgb(24, 24, 24);
            twitchTB.BorderStyle = BorderStyle.FixedSingle;
            twitchTB.Enabled = false;
            twitchTB.Font = new Font("Nirmala UI", 12F);
            twitchTB.ForeColor = Color.WhiteSmoke;
            twitchTB.Location = new Point(221, 39);
            twitchTB.Name = "twitchTB";
            twitchTB.Size = new Size(194, 29);
            twitchTB.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(21, 87);
            label4.Name = "label4";
            label4.Size = new Size(151, 16);
            label4.TabIndex = 74;
            label4.Text = "Background Opacity";
            // 
            // nudFade
            // 
            nudFade.Font = new Font("Segoe UI", 12F);
            nudFade.Location = new Point(554, 183);
            nudFade.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudFade.Name = "nudFade";
            nudFade.RightToLeft = RightToLeft.No;
            nudFade.Size = new Size(120, 29);
            nudFade.TabIndex = 72;
            nudFade.TextAlign = HorizontalAlignment.Center;
            // 
            // nudZoom
            // 
            nudZoom.Font = new Font("Segoe UI", 12F);
            nudZoom.Location = new Point(421, 183);
            nudZoom.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudZoom.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudZoom.Name = "nudZoom";
            nudZoom.RightToLeft = RightToLeft.No;
            nudZoom.Size = new Size(120, 29);
            nudZoom.TabIndex = 71;
            nudZoom.TextAlign = HorizontalAlignment.Center;
            nudZoom.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // chkBorder
            // 
            chkBorder.BackColor = Color.Transparent;
            chkBorder.Background = true;
            chkBorder.Background_WidthPen = 2F;
            chkBorder.BackgroundPen = true;
            chkBorder.Checked = true;
            chkBorder.ColorBackground = Color.FromArgb(24, 24, 24);
            chkBorder.ColorBackground_1 = Color.FromArgb(46, 140, 18);
            chkBorder.ColorBackground_2 = Color.FromArgb(46, 140, 18);
            chkBorder.ColorBackground_Pen = Color.FromArgb(83, 253, 25);
            chkBorder.ColorChecked = Color.FromArgb(83, 253, 25);
            chkBorder.ColorPen_1 = Color.FromArgb(46, 140, 18);
            chkBorder.ColorPen_2 = Color.FromArgb(46, 140, 18);
            chkBorder.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            chkBorder.Effect_1_ColorBackground = Color.FromArgb(46, 140, 18);
            chkBorder.Effect_1_Transparency = 25;
            chkBorder.Effect_2 = false;
            chkBorder.Effect_2_ColorBackground = Color.White;
            chkBorder.Effect_2_Transparency = 15;
            chkBorder.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkBorder.ForeColor = Color.FromArgb(245, 245, 245);
            chkBorder.LinearGradient_Background = false;
            chkBorder.LinearGradientPen = false;
            chkBorder.Location = new Point(315, 74);
            chkBorder.Name = "chkBorder";
            chkBorder.RGB = false;
            chkBorder.Rounding = true;
            chkBorder.RoundingInt = 25;
            chkBorder.Size = new Size(121, 45);
            chkBorder.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkBorder.TabIndex = 70;
            chkBorder.Tag = "Cyber";
            chkBorder.TextButton = "Border";
            chkBorder.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkBorder.Timer_Effect_1 = 1;
            chkBorder.Timer_RGB = 300;
            // 
            // cmbStroke
            // 
            cmbStroke.BackColor = Color.FromArgb(24, 24, 24);
            cmbStroke.BaseColor = Color.FromArgb(25, 27, 29);
            cmbStroke.BGColor = Color.FromArgb(45, 47, 49);
            cmbStroke.DrawMode = DrawMode.OwnerDrawFixed;
            cmbStroke.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStroke.Font = new Font("Arial", 8.25F);
            cmbStroke.ForeColor = Color.WhiteSmoke;
            cmbStroke.FormattingEnabled = true;
            cmbStroke.HoverColor = Color.FromArgb(35, 168, 109);
            cmbStroke.HoverFontColor = Color.White;
            cmbStroke.ItemHeight = 18;
            cmbStroke.Items.AddRange(new object[] { "Off", "Thin", "Medium", "Thick", "Thicker" });
            cmbStroke.Location = new Point(287, 185);
            cmbStroke.Name = "cmbStroke";
            cmbStroke.Size = new Size(121, 24);
            cmbStroke.TabIndex = 69;
            // 
            // cmbFontSize
            // 
            cmbFontSize.BackColor = Color.FromArgb(24, 24, 24);
            cmbFontSize.BaseColor = Color.FromArgb(25, 27, 29);
            cmbFontSize.BGColor = Color.FromArgb(45, 47, 49);
            cmbFontSize.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFontSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFontSize.Font = new Font("Arial", 8.25F);
            cmbFontSize.ForeColor = Color.WhiteSmoke;
            cmbFontSize.FormattingEnabled = true;
            cmbFontSize.HoverColor = Color.FromArgb(35, 168, 109);
            cmbFontSize.HoverFontColor = Color.White;
            cmbFontSize.ItemHeight = 18;
            cmbFontSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cmbFontSize.Location = new Point(154, 185);
            cmbFontSize.Name = "cmbFontSize";
            cmbFontSize.Size = new Size(121, 24);
            cmbFontSize.TabIndex = 68;
            // 
            // chkBots
            // 
            chkBots.BackColor = Color.Transparent;
            chkBots.Background = true;
            chkBots.Background_WidthPen = 2F;
            chkBots.BackgroundPen = true;
            chkBots.Checked = true;
            chkBots.ColorBackground = Color.FromArgb(24, 24, 24);
            chkBots.ColorBackground_1 = Color.FromArgb(46, 140, 18);
            chkBots.ColorBackground_2 = Color.FromArgb(46, 140, 18);
            chkBots.ColorBackground_Pen = Color.FromArgb(83, 253, 25);
            chkBots.ColorChecked = Color.FromArgb(83, 253, 25);
            chkBots.ColorPen_1 = Color.FromArgb(46, 140, 18);
            chkBots.ColorPen_2 = Color.FromArgb(46, 140, 18);
            chkBots.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            chkBots.Effect_1_ColorBackground = Color.FromArgb(46, 140, 18);
            chkBots.Effect_1_Transparency = 25;
            chkBots.Effect_2 = false;
            chkBots.Effect_2_ColorBackground = Color.White;
            chkBots.Effect_2_Transparency = 15;
            chkBots.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkBots.ForeColor = Color.FromArgb(245, 245, 245);
            chkBots.LinearGradient_Background = false;
            chkBots.LinearGradientPen = false;
            chkBots.Location = new Point(559, 74);
            chkBots.Name = "chkBots";
            chkBots.RGB = false;
            chkBots.Rounding = true;
            chkBots.RoundingInt = 25;
            chkBots.Size = new Size(121, 45);
            chkBots.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkBots.TabIndex = 67;
            chkBots.Tag = "Cyber";
            chkBots.TextButton = "Bots";
            chkBots.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkBots.Timer_Effect_1 = 1;
            chkBots.Timer_RGB = 300;
            // 
            // chkCommands
            // 
            chkCommands.BackColor = Color.Transparent;
            chkCommands.Background = true;
            chkCommands.Background_WidthPen = 2F;
            chkCommands.BackgroundPen = true;
            chkCommands.Checked = true;
            chkCommands.ColorBackground = Color.FromArgb(24, 24, 24);
            chkCommands.ColorBackground_1 = Color.FromArgb(46, 140, 18);
            chkCommands.ColorBackground_2 = Color.FromArgb(46, 140, 18);
            chkCommands.ColorBackground_Pen = Color.FromArgb(83, 253, 25);
            chkCommands.ColorChecked = Color.FromArgb(83, 253, 25);
            chkCommands.ColorPen_1 = Color.FromArgb(46, 140, 18);
            chkCommands.ColorPen_2 = Color.FromArgb(46, 140, 18);
            chkCommands.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            chkCommands.Effect_1_ColorBackground = Color.FromArgb(46, 140, 18);
            chkCommands.Effect_1_Transparency = 25;
            chkCommands.Effect_2 = false;
            chkCommands.Effect_2_ColorBackground = Color.White;
            chkCommands.Effect_2_Transparency = 15;
            chkCommands.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkCommands.ForeColor = Color.FromArgb(245, 245, 245);
            chkCommands.LinearGradient_Background = false;
            chkCommands.LinearGradientPen = false;
            chkCommands.Location = new Point(432, 74);
            chkCommands.Name = "chkCommands";
            chkCommands.RGB = false;
            chkCommands.Rounding = true;
            chkCommands.RoundingInt = 25;
            chkCommands.Size = new Size(136, 45);
            chkCommands.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkCommands.TabIndex = 66;
            chkCommands.Tag = "Cyber";
            chkCommands.TextButton = "Commands";
            chkCommands.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkCommands.Timer_Effect_1 = 1;
            chkCommands.Timer_RGB = 300;
            // 
            // chkBadges
            // 
            chkBadges.BackColor = Color.Transparent;
            chkBadges.Background = true;
            chkBadges.Background_WidthPen = 2F;
            chkBadges.BackgroundPen = true;
            chkBadges.Checked = true;
            chkBadges.ColorBackground = Color.FromArgb(24, 24, 24);
            chkBadges.ColorBackground_1 = Color.FromArgb(46, 140, 18);
            chkBadges.ColorBackground_2 = Color.FromArgb(46, 140, 18);
            chkBadges.ColorBackground_Pen = Color.FromArgb(83, 253, 25);
            chkBadges.ColorChecked = Color.FromArgb(83, 253, 25);
            chkBadges.ColorPen_1 = Color.FromArgb(46, 140, 18);
            chkBadges.ColorPen_2 = Color.FromArgb(46, 140, 18);
            chkBadges.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            chkBadges.Effect_1_ColorBackground = Color.FromArgb(46, 140, 18);
            chkBadges.Effect_1_Transparency = 25;
            chkBadges.Effect_2 = false;
            chkBadges.Effect_2_ColorBackground = Color.White;
            chkBadges.Effect_2_Transparency = 15;
            chkBadges.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkBadges.ForeColor = Color.FromArgb(245, 245, 245);
            chkBadges.LinearGradient_Background = false;
            chkBadges.LinearGradientPen = false;
            chkBadges.Location = new Point(559, 20);
            chkBadges.Name = "chkBadges";
            chkBadges.RGB = false;
            chkBadges.Rounding = true;
            chkBadges.RoundingInt = 25;
            chkBadges.Size = new Size(121, 45);
            chkBadges.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkBadges.TabIndex = 65;
            chkBadges.Tag = "Cyber";
            chkBadges.TextButton = "Badges";
            chkBadges.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkBadges.Timer_Effect_1 = 1;
            chkBadges.Timer_RGB = 300;
            // 
            // cmbFontFamily
            // 
            cmbFontFamily.BackColor = Color.FromArgb(24, 24, 24);
            cmbFontFamily.BaseColor = Color.FromArgb(25, 27, 29);
            cmbFontFamily.BGColor = Color.FromArgb(45, 47, 49);
            cmbFontFamily.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFontFamily.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFontFamily.FlatStyle = FlatStyle.System;
            cmbFontFamily.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFontFamily.ForeColor = Color.WhiteSmoke;
            cmbFontFamily.FormattingEnabled = true;
            cmbFontFamily.HoverColor = Color.FromArgb(35, 168, 109);
            cmbFontFamily.HoverFontColor = Color.White;
            cmbFontFamily.ItemHeight = 18;
            cmbFontFamily.Items.AddRange(new object[] { "Basic", "Arial", "Calibri", "Cambria", "Candara", "Consolas", "Corbel", "Century Gothic", "Franklin Gothic Heavy", "Franklin Gothic Medium", "Impact", "Lucida Sans Unicode", "Segoe UI", "Segoe UI Semibold", "Tahoma", "Trebuchet MS", "Verdana" });
            cmbFontFamily.Location = new Point(20, 185);
            cmbFontFamily.MaxDropDownItems = 10;
            cmbFontFamily.Name = "cmbFontFamily";
            cmbFontFamily.Size = new Size(121, 24);
            cmbFontFamily.TabIndex = 64;
            cmbFontFamily.SelectedIndexChanged += cmbFontFamily_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackgroundColor = Color.FromArgb(45, 45, 45);
            btnSave.ButtonImage = null;
            btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSave.ButtonText = "Save/Reload";
            btnSave.ClickBackColor = Color.FromArgb(46, 140, 18);
            btnSave.ClickTextColor = Color.FromArgb(10, 10, 10);
            btnSave.CornerRadius = 10;
            btnSave.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Horizontal_Alignment = StringAlignment.Center;
            btnSave.HoverBackgroundColor = Color.FromArgb(83, 253, 25);
            btnSave.HoverTextColor = Color.FromArgb(10, 10, 10);
            btnSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSave.Location = new Point(696, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 34);
            btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSave.TabIndex = 63;
            btnSave.TextColor = Color.FromArgb(120, 255, 90);
            btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSave.Vertical_Alignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // chkAnimate
            // 
            chkAnimate.BackColor = Color.Transparent;
            chkAnimate.Background = true;
            chkAnimate.Background_WidthPen = 2F;
            chkAnimate.BackgroundPen = true;
            chkAnimate.Checked = true;
            chkAnimate.ColorBackground = Color.FromArgb(24, 24, 24);
            chkAnimate.ColorBackground_1 = Color.FromArgb(46, 140, 18);
            chkAnimate.ColorBackground_2 = Color.FromArgb(46, 140, 18);
            chkAnimate.ColorBackground_Pen = Color.FromArgb(83, 253, 25);
            chkAnimate.ColorChecked = Color.FromArgb(83, 253, 25);
            chkAnimate.ColorPen_1 = Color.FromArgb(46, 140, 18);
            chkAnimate.ColorPen_2 = Color.FromArgb(46, 140, 18);
            chkAnimate.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            chkAnimate.Effect_1_ColorBackground = Color.FromArgb(46, 140, 18);
            chkAnimate.Effect_1_Transparency = 25;
            chkAnimate.Effect_2 = false;
            chkAnimate.Effect_2_ColorBackground = Color.White;
            chkAnimate.Effect_2_Transparency = 15;
            chkAnimate.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            chkAnimate.ForeColor = Color.FromArgb(245, 245, 245);
            chkAnimate.LinearGradient_Background = false;
            chkAnimate.LinearGradientPen = false;
            chkAnimate.Location = new Point(432, 20);
            chkAnimate.Name = "chkAnimate";
            chkAnimate.RGB = false;
            chkAnimate.Rounding = true;
            chkAnimate.RoundingInt = 25;
            chkAnimate.Size = new Size(121, 45);
            chkAnimate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkAnimate.TabIndex = 62;
            chkAnimate.Tag = "Cyber";
            chkAnimate.TextButton = "Animate";
            chkAnimate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkAnimate.Timer_Effect_1 = 1;
            chkAnimate.Timer_RGB = 300;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("MV Boli", 12F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(20, 151);
            label7.Name = "label7";
            label7.Size = new Size(121, 26);
            label7.TabIndex = 61;
            label7.Text = "Select Font";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // fontlable
            // 
            fontlable.AutoSize = true;
            fontlable.BackColor = Color.Transparent;
            fontlable.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            fontlable.ForeColor = Color.WhiteSmoke;
            fontlable.Location = new Point(154, 161);
            fontlable.Name = "fontlable";
            fontlable.Size = new Size(73, 16);
            fontlable.TabIndex = 60;
            fontlable.Text = "Font Size";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(287, 161);
            label6.Name = "label6";
            label6.Size = new Size(53, 16);
            label6.TabIndex = 59;
            label6.Text = "Stroke";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(557, 161);
            label5.Name = "label5";
            label5.Size = new Size(114, 16);
            label5.TabIndex = 58;
            label5.Text = "Fade (seconds)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(452, 161);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 56;
            label2.Text = "Zoom";
            // 
            // twitchCheckBox
            // 
            twitchCheckBox.BackColor = Color.Transparent;
            twitchCheckBox.Background = true;
            twitchCheckBox.Background_WidthPen = 2F;
            twitchCheckBox.BackgroundPen = true;
            twitchCheckBox.Checked = false;
            twitchCheckBox.ColorBackground = Color.FromArgb(24, 24, 24);
            twitchCheckBox.ColorBackground_1 = Color.FromArgb(46, 140, 18);
            twitchCheckBox.ColorBackground_2 = Color.FromArgb(46, 140, 18);
            twitchCheckBox.ColorBackground_Pen = Color.FromArgb(83, 253, 25);
            twitchCheckBox.ColorChecked = Color.FromArgb(83, 253, 25);
            twitchCheckBox.ColorPen_1 = Color.FromArgb(46, 140, 18);
            twitchCheckBox.ColorPen_2 = Color.FromArgb(46, 140, 18);
            twitchCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            twitchCheckBox.Effect_1_ColorBackground = Color.FromArgb(46, 140, 18);
            twitchCheckBox.Effect_1_Transparency = 25;
            twitchCheckBox.Effect_2 = false;
            twitchCheckBox.Effect_2_ColorBackground = Color.White;
            twitchCheckBox.Effect_2_Transparency = 15;
            twitchCheckBox.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            twitchCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            twitchCheckBox.LinearGradient_Background = false;
            twitchCheckBox.LinearGradientPen = false;
            twitchCheckBox.Location = new Point(207, 2);
            twitchCheckBox.Name = "twitchCheckBox";
            twitchCheckBox.RGB = false;
            twitchCheckBox.Rounding = true;
            twitchCheckBox.RoundingInt = 25;
            twitchCheckBox.Size = new Size(53, 45);
            twitchCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            twitchCheckBox.TabIndex = 75;
            twitchCheckBox.Tag = "Cyber";
            twitchCheckBox.TextButton = "";
            twitchCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            twitchCheckBox.Timer_Effect_1 = 1;
            twitchCheckBox.Timer_RGB = 300;
            twitchCheckBox.CheckedChanged += twitchCheckBox_CheckedChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Nirmala Text", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(21, 260);
            label3.Name = "label3";
            label3.Size = new Size(169, 33);
            label3.TabIndex = 57;
            label3.Text = "Made by Dralder   v";
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(parrotButton3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(parrotButton2);
            panel2.Controls.Add(AlertMessageRTB);
            panel2.Controls.Add(foreverLabel2);
            panel2.Controls.Add(nightLabel6);
            panel2.Controls.Add(obspassTB);
            panel2.Controls.Add(nightLabel5);
            panel2.Controls.Add(obsportTB);
            panel2.Controls.Add(nightLabel4);
            panel2.Controls.Add(obshostTB);
            panel2.Controls.Add(foreverLabel1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(nightLabel3);
            panel2.Controls.Add(webhookTB);
            panel2.Controls.Add(nightLabel2);
            panel2.Controls.Add(channelTB);
            panel2.Controls.Add(nightLabel1);
            panel2.Controls.Add(tokenTB);
            panel2.Controls.Add(discordCheckBox);
            panel2.Controls.Add(telegramCheckBox);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 271);
            panel2.TabIndex = 57;
            panel2.Visible = false;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(55, 55, 55);
            label9.ForeColor = Color.FromArgb(55, 55, 55);
            label9.Location = new Point(403, 28);
            label9.Name = "label9";
            label9.Size = new Size(3, 225);
            label9.TabIndex = 94;
            label9.Text = "label9";
            // 
            // parrotButton3
            // 
            parrotButton3.BackgroundColor = Color.FromArgb(45, 45, 45);
            parrotButton3.ButtonImage = null;
            parrotButton3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton3.ButtonText = "Clear";
            parrotButton3.ClickBackColor = Color.FromArgb(46, 140, 18);
            parrotButton3.ClickTextColor = Color.FromArgb(10, 10, 10);
            parrotButton3.CornerRadius = 10;
            parrotButton3.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton3.Horizontal_Alignment = StringAlignment.Center;
            parrotButton3.HoverBackgroundColor = Color.FromArgb(83, 253, 25);
            parrotButton3.HoverTextColor = Color.FromArgb(10, 10, 10);
            parrotButton3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton3.Location = new Point(559, 219);
            parrotButton3.Name = "parrotButton3";
            parrotButton3.Size = new Size(62, 34);
            parrotButton3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton3.TabIndex = 93;
            parrotButton3.TextColor = Color.FromArgb(120, 255, 90);
            parrotButton3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton3.Vertical_Alignment = StringAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(651, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 92;
            pictureBox1.TabStop = false;
            // 
            // parrotButton2
            // 
            parrotButton2.BackgroundColor = Color.FromArgb(45, 45, 45);
            parrotButton2.ButtonImage = null;
            parrotButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton2.ButtonText = "Attach Media";
            parrotButton2.ClickBackColor = Color.FromArgb(46, 140, 18);
            parrotButton2.ClickTextColor = Color.FromArgb(10, 10, 10);
            parrotButton2.CornerRadius = 10;
            parrotButton2.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton2.Horizontal_Alignment = StringAlignment.Center;
            parrotButton2.HoverBackgroundColor = Color.FromArgb(83, 253, 25);
            parrotButton2.HoverTextColor = Color.FromArgb(10, 10, 10);
            parrotButton2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton2.Location = new Point(423, 219);
            parrotButton2.Name = "parrotButton2";
            parrotButton2.Size = new Size(130, 34);
            parrotButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton2.TabIndex = 91;
            parrotButton2.TextColor = Color.FromArgb(120, 255, 90);
            parrotButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton2.Vertical_Alignment = StringAlignment.Center;
            parrotButton2.Click += parrotButton2_Click;
            // 
            // AlertMessageRTB
            // 
            AlertMessageRTB.BackColor = Color.FromArgb(45, 45, 45);
            AlertMessageRTB.BorderStyle = BorderStyle.None;
            AlertMessageRTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlertMessageRTB.ForeColor = SystemColors.ButtonHighlight;
            AlertMessageRTB.Location = new Point(424, 46);
            AlertMessageRTB.Name = "AlertMessageRTB";
            AlertMessageRTB.Size = new Size(221, 154);
            AlertMessageRTB.TabIndex = 90;
            AlertMessageRTB.Text = "Test Alert Message!";
            // 
            // foreverLabel2
            // 
            foreverLabel2.AutoSize = true;
            foreverLabel2.BackColor = Color.Transparent;
            foreverLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreverLabel2.ForeColor = Color.WhiteSmoke;
            foreverLabel2.Location = new Point(423, 16);
            foreverLabel2.Name = "foreverLabel2";
            foreverLabel2.Size = new Size(108, 21);
            foreverLabel2.TabIndex = 89;
            foreverLabel2.Text = "Alert Message";
            foreverLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // nightLabel6
            // 
            nightLabel6.BackColor = Color.Transparent;
            nightLabel6.Font = new Font("Segoe UI", 9F);
            nightLabel6.ForeColor = Color.FromArgb(224, 224, 224);
            nightLabel6.Location = new Point(257, 156);
            nightLabel6.Name = "nightLabel6";
            nightLabel6.Size = new Size(130, 15);
            nightLabel6.TabIndex = 78;
            nightLabel6.Text = "Password";
            nightLabel6.TextAlign = ContentAlignment.TopCenter;
            // 
            // obspassTB
            // 
            obspassTB.BackColor = Color.FromArgb(41, 41, 41);
            obspassTB.BorderStyle = BorderStyle.FixedSingle;
            obspassTB.ColorA = Color.FromArgb(31, 31, 31);
            obspassTB.ColorB = Color.FromArgb(41, 41, 41);
            obspassTB.ColorC = Color.FromArgb(51, 51, 51);
            obspassTB.ColorD = Color.FromArgb(0, 0, 0, 0);
            obspassTB.ColorE = Color.FromArgb(25, 255, 255, 255);
            obspassTB.ColorF = Color.Black;
            obspassTB.ForeColor = Color.FromArgb(59, 181, 18);
            obspassTB.Location = new Point(257, 177);
            obspassTB.Name = "obspassTB";
            obspassTB.PasswordChar = '#';
            obspassTB.Size = new Size(130, 23);
            obspassTB.TabIndex = 77;
            obspassTB.TextAlign = HorizontalAlignment.Center;
            // 
            // nightLabel5
            // 
            nightLabel5.BackColor = Color.Transparent;
            nightLabel5.Font = new Font("Segoe UI", 9F);
            nightLabel5.ForeColor = Color.FromArgb(224, 224, 224);
            nightLabel5.Location = new Point(257, 103);
            nightLabel5.Name = "nightLabel5";
            nightLabel5.Size = new Size(130, 15);
            nightLabel5.TabIndex = 76;
            nightLabel5.Text = "Port";
            nightLabel5.TextAlign = ContentAlignment.TopCenter;
            // 
            // obsportTB
            // 
            obsportTB.BackColor = Color.FromArgb(41, 41, 41);
            obsportTB.BorderStyle = BorderStyle.FixedSingle;
            obsportTB.ColorA = Color.FromArgb(31, 31, 31);
            obsportTB.ColorB = Color.FromArgb(41, 41, 41);
            obsportTB.ColorC = Color.FromArgb(51, 51, 51);
            obsportTB.ColorD = Color.FromArgb(0, 0, 0, 0);
            obsportTB.ColorE = Color.FromArgb(25, 255, 255, 255);
            obsportTB.ColorF = Color.Black;
            obsportTB.ForeColor = Color.FromArgb(59, 181, 18);
            obsportTB.Location = new Point(257, 124);
            obsportTB.Name = "obsportTB";
            obsportTB.Size = new Size(130, 23);
            obsportTB.TabIndex = 75;
            obsportTB.Text = "4455";
            obsportTB.TextAlign = HorizontalAlignment.Center;
            // 
            // nightLabel4
            // 
            nightLabel4.BackColor = Color.Transparent;
            nightLabel4.Font = new Font("Segoe UI", 9F);
            nightLabel4.ForeColor = Color.FromArgb(224, 224, 224);
            nightLabel4.Location = new Point(257, 51);
            nightLabel4.Name = "nightLabel4";
            nightLabel4.Size = new Size(130, 15);
            nightLabel4.TabIndex = 74;
            nightLabel4.Text = "Host";
            nightLabel4.TextAlign = ContentAlignment.TopCenter;
            // 
            // obshostTB
            // 
            obshostTB.BackColor = Color.FromArgb(41, 41, 41);
            obshostTB.BorderStyle = BorderStyle.FixedSingle;
            obshostTB.ColorA = Color.FromArgb(31, 31, 31);
            obshostTB.ColorB = Color.FromArgb(41, 41, 41);
            obshostTB.ColorC = Color.FromArgb(51, 51, 51);
            obshostTB.ColorD = Color.FromArgb(0, 0, 0, 0);
            obshostTB.ColorE = Color.FromArgb(25, 255, 255, 255);
            obshostTB.ColorF = Color.Black;
            obshostTB.ForeColor = Color.FromArgb(59, 181, 18);
            obshostTB.Location = new Point(257, 72);
            obshostTB.Name = "obshostTB";
            obshostTB.Size = new Size(130, 23);
            obshostTB.TabIndex = 73;
            obshostTB.Text = "localhost";
            obshostTB.TextAlign = HorizontalAlignment.Center;
            // 
            // foreverLabel1
            // 
            foreverLabel1.BackColor = Color.Transparent;
            foreverLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreverLabel1.ForeColor = Color.Yellow;
            foreverLabel1.Location = new Point(257, 16);
            foreverLabel1.Name = "foreverLabel1";
            foreverLabel1.Size = new Size(130, 21);
            foreverLabel1.TabIndex = 72;
            foreverLabel1.Text = "OBS";
            foreverLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(55, 55, 55);
            label8.ForeColor = Color.FromArgb(55, 55, 55);
            label8.Location = new Point(238, 28);
            label8.Name = "label8";
            label8.Size = new Size(3, 225);
            label8.TabIndex = 71;
            label8.Text = "label8";
            // 
            // nightLabel3
            // 
            nightLabel3.AutoSize = true;
            nightLabel3.BackColor = Color.Transparent;
            nightLabel3.Font = new Font("Segoe UI", 9F);
            nightLabel3.ForeColor = Color.FromArgb(224, 224, 224);
            nightLabel3.Location = new Point(21, 201);
            nightLabel3.Name = "nightLabel3";
            nightLabel3.Size = new Size(82, 15);
            nightLabel3.TabIndex = 70;
            nightLabel3.Text = "Webhook URL";
            // 
            // webhookTB
            // 
            webhookTB.BackColor = Color.FromArgb(41, 41, 41);
            webhookTB.BorderStyle = BorderStyle.FixedSingle;
            webhookTB.ColorA = Color.FromArgb(31, 31, 31);
            webhookTB.ColorB = Color.FromArgb(41, 41, 41);
            webhookTB.ColorC = Color.FromArgb(51, 51, 51);
            webhookTB.ColorD = Color.FromArgb(0, 0, 0, 0);
            webhookTB.ColorE = Color.FromArgb(25, 255, 255, 255);
            webhookTB.ColorF = Color.Black;
            webhookTB.Enabled = false;
            webhookTB.ForeColor = Color.FromArgb(59, 181, 18);
            webhookTB.Location = new Point(21, 219);
            webhookTB.Name = "webhookTB";
            webhookTB.PasswordChar = '#';
            webhookTB.Size = new Size(200, 23);
            webhookTB.TabIndex = 69;
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI", 9F);
            nightLabel2.ForeColor = Color.FromArgb(224, 224, 224);
            nightLabel2.Location = new Point(21, 103);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(65, 15);
            nightLabel2.TabIndex = 67;
            nightLabel2.Text = "Channel ID";
            // 
            // channelTB
            // 
            channelTB.BackColor = Color.FromArgb(41, 41, 41);
            channelTB.BorderStyle = BorderStyle.FixedSingle;
            channelTB.ColorA = Color.FromArgb(31, 31, 31);
            channelTB.ColorB = Color.FromArgb(41, 41, 41);
            channelTB.ColorC = Color.FromArgb(51, 51, 51);
            channelTB.ColorD = Color.FromArgb(0, 0, 0, 0);
            channelTB.ColorE = Color.FromArgb(25, 255, 255, 255);
            channelTB.ColorF = Color.Black;
            channelTB.Enabled = false;
            channelTB.ForeColor = Color.FromArgb(59, 181, 18);
            channelTB.Location = new Point(20, 124);
            channelTB.Name = "channelTB";
            channelTB.Size = new Size(200, 23);
            channelTB.TabIndex = 66;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 9F);
            nightLabel1.ForeColor = Color.FromArgb(224, 224, 224);
            nightLabel1.Location = new Point(21, 51);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(60, 15);
            nightLabel1.TabIndex = 65;
            nightLabel1.Text = "Bot Token";
            // 
            // tokenTB
            // 
            tokenTB.BackColor = Color.FromArgb(41, 41, 41);
            tokenTB.BorderStyle = BorderStyle.FixedSingle;
            tokenTB.ColorA = Color.FromArgb(31, 31, 31);
            tokenTB.ColorB = Color.FromArgb(41, 41, 41);
            tokenTB.ColorC = Color.FromArgb(51, 51, 51);
            tokenTB.ColorD = Color.FromArgb(0, 0, 0, 0);
            tokenTB.ColorE = Color.FromArgb(25, 255, 255, 255);
            tokenTB.ColorF = Color.Black;
            tokenTB.Enabled = false;
            tokenTB.ForeColor = Color.FromArgb(59, 181, 18);
            tokenTB.Location = new Point(20, 72);
            tokenTB.Name = "tokenTB";
            tokenTB.PasswordChar = '#';
            tokenTB.Size = new Size(200, 23);
            tokenTB.TabIndex = 64;
            // 
            // discordCheckBox
            // 
            discordCheckBox.BackColor = Color.Transparent;
            discordCheckBox.Background = true;
            discordCheckBox.Background_WidthPen = 2F;
            discordCheckBox.BackgroundPen = true;
            discordCheckBox.Checked = false;
            discordCheckBox.ColorBackground = Color.FromArgb(24, 24, 24);
            discordCheckBox.ColorBackground_1 = Color.FromArgb(46, 140, 18);
            discordCheckBox.ColorBackground_2 = Color.FromArgb(46, 140, 18);
            discordCheckBox.ColorBackground_Pen = Color.FromArgb(83, 253, 25);
            discordCheckBox.ColorChecked = Color.FromArgb(83, 253, 25);
            discordCheckBox.ColorPen_1 = Color.FromArgb(46, 140, 18);
            discordCheckBox.ColorPen_2 = Color.FromArgb(46, 140, 18);
            discordCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            discordCheckBox.Effect_1_ColorBackground = Color.FromArgb(46, 140, 18);
            discordCheckBox.Effect_1_Transparency = 25;
            discordCheckBox.Effect_2 = false;
            discordCheckBox.Effect_2_ColorBackground = Color.White;
            discordCheckBox.Effect_2_Transparency = 15;
            discordCheckBox.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            discordCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            discordCheckBox.LinearGradient_Background = false;
            discordCheckBox.LinearGradientPen = false;
            discordCheckBox.Location = new Point(12, 161);
            discordCheckBox.Name = "discordCheckBox";
            discordCheckBox.RGB = false;
            discordCheckBox.Rounding = true;
            discordCheckBox.RoundingInt = 25;
            discordCheckBox.Size = new Size(121, 45);
            discordCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            discordCheckBox.TabIndex = 68;
            discordCheckBox.Tag = "Cyber";
            discordCheckBox.TextButton = "Discord";
            discordCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            discordCheckBox.Timer_Effect_1 = 1;
            discordCheckBox.Timer_RGB = 300;
            discordCheckBox.CheckedChanged += discordCheckBox_CheckedChanged;
            // 
            // telegramCheckBox
            // 
            telegramCheckBox.BackColor = Color.Transparent;
            telegramCheckBox.Background = true;
            telegramCheckBox.Background_WidthPen = 2F;
            telegramCheckBox.BackgroundPen = true;
            telegramCheckBox.Checked = false;
            telegramCheckBox.ColorBackground = Color.FromArgb(24, 24, 24);
            telegramCheckBox.ColorBackground_1 = Color.FromArgb(46, 140, 18);
            telegramCheckBox.ColorBackground_2 = Color.FromArgb(46, 140, 18);
            telegramCheckBox.ColorBackground_Pen = Color.FromArgb(83, 253, 25);
            telegramCheckBox.ColorChecked = Color.FromArgb(83, 253, 25);
            telegramCheckBox.ColorPen_1 = Color.FromArgb(46, 140, 18);
            telegramCheckBox.ColorPen_2 = Color.FromArgb(46, 140, 18);
            telegramCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            telegramCheckBox.Effect_1_ColorBackground = Color.FromArgb(46, 140, 18);
            telegramCheckBox.Effect_1_Transparency = 25;
            telegramCheckBox.Effect_2 = false;
            telegramCheckBox.Effect_2_ColorBackground = Color.White;
            telegramCheckBox.Effect_2_Transparency = 15;
            telegramCheckBox.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold);
            telegramCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            telegramCheckBox.LinearGradient_Background = false;
            telegramCheckBox.LinearGradientPen = false;
            telegramCheckBox.Location = new Point(12, 3);
            telegramCheckBox.Name = "telegramCheckBox";
            telegramCheckBox.RGB = false;
            telegramCheckBox.Rounding = true;
            telegramCheckBox.RoundingInt = 25;
            telegramCheckBox.Size = new Size(121, 45);
            telegramCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            telegramCheckBox.TabIndex = 63;
            telegramCheckBox.Tag = "Cyber";
            telegramCheckBox.TextButton = "Telegram";
            telegramCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            telegramCheckBox.Timer_Effect_1 = 1;
            telegramCheckBox.Timer_RGB = 300;
            telegramCheckBox.CheckedChanged += telegramCheckBox_CheckedChanged;
            // 
            // btnpanel
            // 
            btnpanel.BackgroundColor = Color.FromArgb(45, 45, 45);
            btnpanel.ButtonImage = null;
            btnpanel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnpanel.ButtonText = "> Alerts <";
            btnpanel.ClickBackColor = Color.FromArgb(46, 140, 18);
            btnpanel.ClickTextColor = Color.FromArgb(10, 10, 10);
            btnpanel.CornerRadius = 10;
            btnpanel.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpanel.Horizontal_Alignment = StringAlignment.Center;
            btnpanel.HoverBackgroundColor = Color.FromArgb(83, 253, 25);
            btnpanel.HoverTextColor = Color.FromArgb(10, 10, 10);
            btnpanel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnpanel.Location = new Point(705, 10);
            btnpanel.Name = "btnpanel";
            btnpanel.Size = new Size(112, 37);
            btnpanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnpanel.TabIndex = 64;
            btnpanel.TextColor = Color.FromArgb(120, 255, 90);
            btnpanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnpanel.Vertical_Alignment = StringAlignment.Center;
            btnpanel.Click += btnpanel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(826, 284);
            Controls.Add(label3);
            Controls.Add(btnpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Kick Chat";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFade).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZoom).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox chkBadgesOld;
        private Label label1;
        private ReaLTaiizor.Controls.CrownTextBox txtUsername;
        private Panel panel1;
        private Label label4;
        private ReaLTaiizor.Controls.ParrotSlider sliderBackground;
        private ReaLTaiizor.Controls.CrownNumeric nudFade;
        private ReaLTaiizor.Controls.CrownNumeric nudZoom;
        private ReaLTaiizor.Controls.CyberCheckBox chkBorder;
        private ReaLTaiizor.Controls.ForeverComboBox cmbStroke;
        private ReaLTaiizor.Controls.ForeverComboBox cmbFontSize;
        private ReaLTaiizor.Controls.CyberCheckBox chkBots;
        private ReaLTaiizor.Controls.CyberCheckBox chkCommands;
        private ReaLTaiizor.Controls.CyberCheckBox chkBadges;
        private ReaLTaiizor.Controls.ForeverComboBox cmbFontFamily;
        private ReaLTaiizor.Controls.ParrotButton btnSave;
        private ReaLTaiizor.Controls.CyberCheckBox chkAnimate;
        private Label label7;
        private Label fontlable;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private ReaLTaiizor.Controls.ParrotButton btnpanel;
        private ReaLTaiizor.Controls.CyberCheckBox telegramCheckBox;
        private ReaLTaiizor.Controls.DreamTextBox tokenTB;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.DreamTextBox channelTB;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private ReaLTaiizor.Controls.DreamTextBox webhookTB;
        private ReaLTaiizor.Controls.CyberCheckBox discordCheckBox;
        private Label label8;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel4;
        private ReaLTaiizor.Controls.DreamTextBox obshostTB;
        private ReaLTaiizor.Controls.NightLabel nightLabel6;
        private ReaLTaiizor.Controls.DreamTextBox obspassTB;
        private ReaLTaiizor.Controls.NightLabel nightLabel5;
        private ReaLTaiizor.Controls.DreamTextBox obsportTB;
        private Label label9;
        private ReaLTaiizor.Controls.ParrotButton parrotButton3;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton2;
        private RichTextBox AlertMessageRTB;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.CrownTextBox twitchTB;
        private ReaLTaiizor.Controls.CyberCheckBox twitchCheckBox;
        private Label label10;
    }
}
