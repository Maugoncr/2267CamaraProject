namespace _2267CamaraProject
{
    partial class FrmCamaraMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerAnimation = new System.Windows.Forms.Timer(this.components);
            this.topNav = new System.Windows.Forms.Panel();
            this.IconMaxin = new FontAwesome.Sharp.IconButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.iconClose = new FontAwesome.Sharp.IconButton();
            this.iconMini = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNameCam1 = new System.Windows.Forms.Label();
            this.IconIniciarCam = new FontAwesome.Sharp.IconButton();
            this.picCamara = new System.Windows.Forms.PictureBox();
            this.cbCamaraSelect = new System.Windows.Forms.ComboBox();
            this.iconRefresh = new FontAwesome.Sharp.IconButton();
            this.iconCapture = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IconIniciarCam2 = new FontAwesome.Sharp.IconButton();
            this.picCamara2 = new System.Windows.Forms.PictureBox();
            this.cbCamaraSelect2 = new System.Windows.Forms.ComboBox();
            this.iconCapture2 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IconIniciarCam3 = new FontAwesome.Sharp.IconButton();
            this.picCamara3 = new System.Windows.Forms.PictureBox();
            this.cbCamaraSelect3 = new System.Windows.Forms.ComboBox();
            this.iconCapture3 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.IconIniciarCam4 = new FontAwesome.Sharp.IconButton();
            this.picCamara4 = new System.Windows.Forms.PictureBox();
            this.cbCamaraSelect4 = new System.Windows.Forms.ComboBox();
            this.iconCapture4 = new FontAwesome.Sharp.IconButton();
            this.topNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara4)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerAnimation
            // 
            this.TimerAnimation.Interval = 750;
            this.TimerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // topNav
            // 
            this.topNav.BackColor = System.Drawing.Color.Transparent;
            this.topNav.BackgroundImage = global::_2267CamaraProject.Properties.Resources.image__1_;
            this.topNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topNav.Controls.Add(this.IconMaxin);
            this.topNav.Controls.Add(this.pictureBox4);
            this.topNav.Controls.Add(this.iconClose);
            this.topNav.Controls.Add(this.iconMini);
            this.topNav.Controls.Add(this.iconRefresh);
            this.topNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.topNav.Location = new System.Drawing.Point(0, 0);
            this.topNav.Name = "topNav";
            this.topNav.Size = new System.Drawing.Size(1920, 62);
            this.topNav.TabIndex = 1;
            this.topNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topNav_MouseDown);
            // 
            // IconMaxin
            // 
            this.IconMaxin.FlatAppearance.BorderSize = 0;
            this.IconMaxin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconMaxin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.IconMaxin.IconColor = System.Drawing.Color.White;
            this.IconMaxin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMaxin.IconSize = 35;
            this.IconMaxin.Location = new System.Drawing.Point(1778, 0);
            this.IconMaxin.Name = "IconMaxin";
            this.IconMaxin.Size = new System.Drawing.Size(65, 62);
            this.IconMaxin.TabIndex = 41;
            this.IconMaxin.UseVisualStyleBackColor = true;
            this.IconMaxin.Click += new System.EventHandler(this.IconMaxin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_2267CamaraProject.Properties.Resources.SSNE;
            this.pictureBox4.Location = new System.Drawing.Point(12, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(227, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // iconClose
            // 
            this.iconClose.BackColor = System.Drawing.Color.Transparent;
            this.iconClose.FlatAppearance.BorderSize = 0;
            this.iconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.iconClose.IconColor = System.Drawing.Color.White;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.IconSize = 35;
            this.iconClose.Location = new System.Drawing.Point(1849, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(69, 62);
            this.iconClose.TabIndex = 9;
            this.iconClose.UseVisualStyleBackColor = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // iconMini
            // 
            this.iconMini.BackColor = System.Drawing.Color.Transparent;
            this.iconMini.FlatAppearance.BorderSize = 0;
            this.iconMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMini.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMini.IconColor = System.Drawing.Color.White;
            this.iconMini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMini.IconSize = 35;
            this.iconMini.Location = new System.Drawing.Point(1707, 0);
            this.iconMini.Name = "iconMini";
            this.iconMini.Size = new System.Drawing.Size(65, 62);
            this.iconMini.TabIndex = 8;
            this.iconMini.UseVisualStyleBackColor = false;
            this.iconMini.Click += new System.EventHandler(this.iconMini_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::_2267CamaraProject.Properties.Resources.image__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picCamara);
            this.panel1.Controls.Add(this.lbNameCam1);
            this.panel1.Controls.Add(this.IconIniciarCam);
            this.panel1.Controls.Add(this.cbCamaraSelect);
            this.panel1.Controls.Add(this.iconCapture);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 320);
            this.panel1.TabIndex = 2;
            // 
            // lbNameCam1
            // 
            this.lbNameCam1.AutoSize = true;
            this.lbNameCam1.BackColor = System.Drawing.Color.Transparent;
            this.lbNameCam1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCam1.ForeColor = System.Drawing.Color.White;
            this.lbNameCam1.Location = new System.Drawing.Point(669, 10);
            this.lbNameCam1.Name = "lbNameCam1";
            this.lbNameCam1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbNameCam1.Size = new System.Drawing.Size(148, 32);
            this.lbNameCam1.TabIndex = 8;
            this.lbNameCam1.Text = "Loop Trap";
            this.lbNameCam1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IconIniciarCam
            // 
            this.IconIniciarCam.BackColor = System.Drawing.Color.Transparent;
            this.IconIniciarCam.FlatAppearance.BorderSize = 0;
            this.IconIniciarCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconIniciarCam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconIniciarCam.ForeColor = System.Drawing.Color.White;
            this.IconIniciarCam.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.IconIniciarCam.IconColor = System.Drawing.Color.White;
            this.IconIniciarCam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconIniciarCam.IconSize = 50;
            this.IconIniciarCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconIniciarCam.Location = new System.Drawing.Point(301, 3);
            this.IconIniciarCam.Name = "IconIniciarCam";
            this.IconIniciarCam.Size = new System.Drawing.Size(59, 52);
            this.IconIniciarCam.TabIndex = 6;
            this.IconIniciarCam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconIniciarCam.UseVisualStyleBackColor = false;
            this.IconIniciarCam.Click += new System.EventHandler(this.IconIniciarCam_Click);
            // 
            // picCamara
            // 
            this.picCamara.BackColor = System.Drawing.Color.White;
            this.picCamara.Image = global::_2267CamaraProject.Properties.Resources.signal1;
            this.picCamara.Location = new System.Drawing.Point(17, 55);
            this.picCamara.Name = "picCamara";
            this.picCamara.Size = new System.Drawing.Size(794, 251);
            this.picCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamara.TabIndex = 0;
            this.picCamara.TabStop = false;
            // 
            // cbCamaraSelect
            // 
            this.cbCamaraSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCamaraSelect.BackColor = System.Drawing.Color.White;
            this.cbCamaraSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamaraSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCamaraSelect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamaraSelect.FormattingEnabled = true;
            this.cbCamaraSelect.Location = new System.Drawing.Point(17, 16);
            this.cbCamaraSelect.Name = "cbCamaraSelect";
            this.cbCamaraSelect.Size = new System.Drawing.Size(278, 26);
            this.cbCamaraSelect.TabIndex = 5;
            // 
            // iconRefresh
            // 
            this.iconRefresh.BackColor = System.Drawing.Color.Transparent;
            this.iconRefresh.FlatAppearance.BorderSize = 0;
            this.iconRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.iconRefresh.IconColor = System.Drawing.Color.White;
            this.iconRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRefresh.IconSize = 35;
            this.iconRefresh.Location = new System.Drawing.Point(245, 7);
            this.iconRefresh.Name = "iconRefresh";
            this.iconRefresh.Size = new System.Drawing.Size(43, 52);
            this.iconRefresh.TabIndex = 4;
            this.iconRefresh.UseVisualStyleBackColor = false;
            this.iconRefresh.Click += new System.EventHandler(this.iconRefresh_Click);
            // 
            // iconCapture
            // 
            this.iconCapture.BackColor = System.Drawing.Color.Transparent;
            this.iconCapture.FlatAppearance.BorderSize = 0;
            this.iconCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCapture.ForeColor = System.Drawing.Color.White;
            this.iconCapture.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconCapture.IconColor = System.Drawing.Color.White;
            this.iconCapture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCapture.IconSize = 35;
            this.iconCapture.Location = new System.Drawing.Point(358, 5);
            this.iconCapture.Name = "iconCapture";
            this.iconCapture.Size = new System.Drawing.Size(61, 52);
            this.iconCapture.TabIndex = 7;
            this.iconCapture.UseVisualStyleBackColor = false;
            this.iconCapture.Click += new System.EventHandler(this.iconCapture_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImage = global::_2267CamaraProject.Properties.Resources.image__1_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.IconIniciarCam2);
            this.panel2.Controls.Add(this.picCamara2);
            this.panel2.Controls.Add(this.cbCamaraSelect2);
            this.panel2.Controls.Add(this.iconCapture2);
            this.panel2.Location = new System.Drawing.Point(12, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 320);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Midsection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IconIniciarCam2
            // 
            this.IconIniciarCam2.BackColor = System.Drawing.Color.Transparent;
            this.IconIniciarCam2.FlatAppearance.BorderSize = 0;
            this.IconIniciarCam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconIniciarCam2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconIniciarCam2.ForeColor = System.Drawing.Color.White;
            this.IconIniciarCam2.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.IconIniciarCam2.IconColor = System.Drawing.Color.White;
            this.IconIniciarCam2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconIniciarCam2.IconSize = 50;
            this.IconIniciarCam2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconIniciarCam2.Location = new System.Drawing.Point(301, 3);
            this.IconIniciarCam2.Name = "IconIniciarCam2";
            this.IconIniciarCam2.Size = new System.Drawing.Size(59, 52);
            this.IconIniciarCam2.TabIndex = 6;
            this.IconIniciarCam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconIniciarCam2.UseVisualStyleBackColor = false;
            this.IconIniciarCam2.Click += new System.EventHandler(this.IconIniciarCam2_Click);
            // 
            // picCamara2
            // 
            this.picCamara2.BackColor = System.Drawing.Color.White;
            this.picCamara2.Image = global::_2267CamaraProject.Properties.Resources.signal1;
            this.picCamara2.Location = new System.Drawing.Point(17, 55);
            this.picCamara2.Name = "picCamara2";
            this.picCamara2.Size = new System.Drawing.Size(794, 251);
            this.picCamara2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamara2.TabIndex = 0;
            this.picCamara2.TabStop = false;
            // 
            // cbCamaraSelect2
            // 
            this.cbCamaraSelect2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCamaraSelect2.BackColor = System.Drawing.Color.White;
            this.cbCamaraSelect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamaraSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCamaraSelect2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamaraSelect2.FormattingEnabled = true;
            this.cbCamaraSelect2.Location = new System.Drawing.Point(17, 16);
            this.cbCamaraSelect2.Name = "cbCamaraSelect2";
            this.cbCamaraSelect2.Size = new System.Drawing.Size(278, 26);
            this.cbCamaraSelect2.TabIndex = 5;
            // 
            // iconCapture2
            // 
            this.iconCapture2.BackColor = System.Drawing.Color.Transparent;
            this.iconCapture2.FlatAppearance.BorderSize = 0;
            this.iconCapture2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCapture2.ForeColor = System.Drawing.Color.White;
            this.iconCapture2.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconCapture2.IconColor = System.Drawing.Color.White;
            this.iconCapture2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCapture2.IconSize = 35;
            this.iconCapture2.Location = new System.Drawing.Point(358, 3);
            this.iconCapture2.Name = "iconCapture2";
            this.iconCapture2.Size = new System.Drawing.Size(61, 52);
            this.iconCapture2.TabIndex = 7;
            this.iconCapture2.UseVisualStyleBackColor = false;
            this.iconCapture2.Click += new System.EventHandler(this.iconCapture2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BackgroundImage = global::_2267CamaraProject.Properties.Resources.image__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.IconIniciarCam3);
            this.panel3.Controls.Add(this.picCamara3);
            this.panel3.Controls.Add(this.cbCamaraSelect3);
            this.panel3.Controls.Add(this.iconCapture3);
            this.panel3.Location = new System.Drawing.Point(12, 748);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 320);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(683, 10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gas Bath";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IconIniciarCam3
            // 
            this.IconIniciarCam3.BackColor = System.Drawing.Color.Transparent;
            this.IconIniciarCam3.FlatAppearance.BorderSize = 0;
            this.IconIniciarCam3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconIniciarCam3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconIniciarCam3.ForeColor = System.Drawing.Color.White;
            this.IconIniciarCam3.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.IconIniciarCam3.IconColor = System.Drawing.Color.White;
            this.IconIniciarCam3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconIniciarCam3.IconSize = 50;
            this.IconIniciarCam3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconIniciarCam3.Location = new System.Drawing.Point(301, 3);
            this.IconIniciarCam3.Name = "IconIniciarCam3";
            this.IconIniciarCam3.Size = new System.Drawing.Size(59, 52);
            this.IconIniciarCam3.TabIndex = 6;
            this.IconIniciarCam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconIniciarCam3.UseVisualStyleBackColor = false;
            this.IconIniciarCam3.Click += new System.EventHandler(this.IconIniciarCam3_Click);
            // 
            // picCamara3
            // 
            this.picCamara3.BackColor = System.Drawing.Color.White;
            this.picCamara3.Image = global::_2267CamaraProject.Properties.Resources.signal1;
            this.picCamara3.Location = new System.Drawing.Point(17, 55);
            this.picCamara3.Name = "picCamara3";
            this.picCamara3.Size = new System.Drawing.Size(794, 251);
            this.picCamara3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamara3.TabIndex = 0;
            this.picCamara3.TabStop = false;
            // 
            // cbCamaraSelect3
            // 
            this.cbCamaraSelect3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCamaraSelect3.BackColor = System.Drawing.Color.White;
            this.cbCamaraSelect3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamaraSelect3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCamaraSelect3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamaraSelect3.FormattingEnabled = true;
            this.cbCamaraSelect3.Location = new System.Drawing.Point(17, 16);
            this.cbCamaraSelect3.Name = "cbCamaraSelect3";
            this.cbCamaraSelect3.Size = new System.Drawing.Size(278, 26);
            this.cbCamaraSelect3.TabIndex = 5;
            // 
            // iconCapture3
            // 
            this.iconCapture3.BackColor = System.Drawing.Color.Transparent;
            this.iconCapture3.FlatAppearance.BorderSize = 0;
            this.iconCapture3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCapture3.ForeColor = System.Drawing.Color.White;
            this.iconCapture3.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconCapture3.IconColor = System.Drawing.Color.White;
            this.iconCapture3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCapture3.IconSize = 35;
            this.iconCapture3.Location = new System.Drawing.Point(358, 3);
            this.iconCapture3.Name = "iconCapture3";
            this.iconCapture3.Size = new System.Drawing.Size(61, 52);
            this.iconCapture3.TabIndex = 7;
            this.iconCapture3.UseVisualStyleBackColor = false;
            this.iconCapture3.Click += new System.EventHandler(this.iconCapture3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.BackgroundImage = global::_2267CamaraProject.Properties.Resources.image__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.IconIniciarCam4);
            this.panel4.Controls.Add(this.picCamara4);
            this.panel4.Controls.Add(this.cbCamaraSelect4);
            this.panel4.Controls.Add(this.iconCapture4);
            this.panel4.Location = new System.Drawing.Point(913, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(949, 986);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(828, 10);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Facility";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IconIniciarCam4
            // 
            this.IconIniciarCam4.BackColor = System.Drawing.Color.Transparent;
            this.IconIniciarCam4.FlatAppearance.BorderSize = 0;
            this.IconIniciarCam4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconIniciarCam4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconIniciarCam4.ForeColor = System.Drawing.Color.White;
            this.IconIniciarCam4.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.IconIniciarCam4.IconColor = System.Drawing.Color.White;
            this.IconIniciarCam4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconIniciarCam4.IconSize = 50;
            this.IconIniciarCam4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconIniciarCam4.Location = new System.Drawing.Point(311, 3);
            this.IconIniciarCam4.Name = "IconIniciarCam4";
            this.IconIniciarCam4.Size = new System.Drawing.Size(59, 52);
            this.IconIniciarCam4.TabIndex = 6;
            this.IconIniciarCam4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconIniciarCam4.UseVisualStyleBackColor = false;
            this.IconIniciarCam4.Click += new System.EventHandler(this.IconIniciarCam4_Click);
            // 
            // picCamara4
            // 
            this.picCamara4.BackColor = System.Drawing.Color.White;
            this.picCamara4.Image = global::_2267CamaraProject.Properties.Resources.signal1;
            this.picCamara4.Location = new System.Drawing.Point(17, 55);
            this.picCamara4.Name = "picCamara4";
            this.picCamara4.Size = new System.Drawing.Size(913, 917);
            this.picCamara4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamara4.TabIndex = 0;
            this.picCamara4.TabStop = false;
            // 
            // cbCamaraSelect4
            // 
            this.cbCamaraSelect4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCamaraSelect4.BackColor = System.Drawing.Color.White;
            this.cbCamaraSelect4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamaraSelect4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCamaraSelect4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamaraSelect4.FormattingEnabled = true;
            this.cbCamaraSelect4.Location = new System.Drawing.Point(17, 16);
            this.cbCamaraSelect4.Name = "cbCamaraSelect4";
            this.cbCamaraSelect4.Size = new System.Drawing.Size(278, 26);
            this.cbCamaraSelect4.TabIndex = 5;
            // 
            // iconCapture4
            // 
            this.iconCapture4.BackColor = System.Drawing.Color.Transparent;
            this.iconCapture4.FlatAppearance.BorderSize = 0;
            this.iconCapture4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCapture4.ForeColor = System.Drawing.Color.White;
            this.iconCapture4.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconCapture4.IconColor = System.Drawing.Color.White;
            this.iconCapture4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCapture4.IconSize = 35;
            this.iconCapture4.Location = new System.Drawing.Point(367, 3);
            this.iconCapture4.Name = "iconCapture4";
            this.iconCapture4.Size = new System.Drawing.Size(61, 52);
            this.iconCapture4.TabIndex = 7;
            this.iconCapture4.UseVisualStyleBackColor = false;
            this.iconCapture4.Click += new System.EventHandler(this.iconCapture4_Click);
            // 
            // FrmCamaraMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCamaraMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCamaraMonitor_FormClosed);
            this.Load += new System.EventHandler(this.FrmCamaraMonitor_Load);
            this.topNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCamara;
        private System.Windows.Forms.Timer TimerAnimation;
        private System.Windows.Forms.Panel topNav;
        private FontAwesome.Sharp.IconButton iconClose;
        private FontAwesome.Sharp.IconButton iconMini;
        private FontAwesome.Sharp.IconButton iconCapture;
        private FontAwesome.Sharp.IconButton IconIniciarCam;
        private System.Windows.Forms.ComboBox cbCamaraSelect;
        private FontAwesome.Sharp.IconButton iconRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameCam1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton IconIniciarCam2;
        private System.Windows.Forms.PictureBox picCamara2;
        private System.Windows.Forms.ComboBox cbCamaraSelect2;
        private FontAwesome.Sharp.IconButton iconCapture2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton IconIniciarCam3;
        private System.Windows.Forms.PictureBox picCamara3;
        private System.Windows.Forms.ComboBox cbCamaraSelect3;
        private FontAwesome.Sharp.IconButton iconCapture3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton IconIniciarCam4;
        private System.Windows.Forms.PictureBox picCamara4;
        private System.Windows.Forms.ComboBox cbCamaraSelect4;
        private FontAwesome.Sharp.IconButton iconCapture4;
        private FontAwesome.Sharp.IconButton IconMaxin;
    }
}

