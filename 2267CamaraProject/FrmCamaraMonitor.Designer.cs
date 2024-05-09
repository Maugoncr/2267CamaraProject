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
            this.iconClose = new FontAwesome.Sharp.IconButton();
            this.iconMini = new FontAwesome.Sharp.IconButton();
            this.iconCapture = new FontAwesome.Sharp.IconButton();
            this.IconIniciarCam = new FontAwesome.Sharp.IconButton();
            this.cbCamaraSelect = new System.Windows.Forms.ComboBox();
            this.iconRefresh = new FontAwesome.Sharp.IconButton();
            this.picCamara = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerAnimation
            // 
            this.TimerAnimation.Interval = 1000;
            this.TimerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // topNav
            // 
            this.topNav.BackColor = System.Drawing.Color.Transparent;
            this.topNav.BackgroundImage = global::_2267CamaraProject.Properties.Resources.image__1_;
            this.topNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topNav.Controls.Add(this.iconClose);
            this.topNav.Controls.Add(this.iconMini);
            this.topNav.Controls.Add(this.iconCapture);
            this.topNav.Controls.Add(this.IconIniciarCam);
            this.topNav.Controls.Add(this.cbCamaraSelect);
            this.topNav.Controls.Add(this.iconRefresh);
            this.topNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.topNav.Location = new System.Drawing.Point(0, 0);
            this.topNav.Name = "topNav";
            this.topNav.Size = new System.Drawing.Size(1200, 62);
            this.topNav.TabIndex = 1;
            this.topNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topNav_MouseDown);
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
            this.iconClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconClose.Location = new System.Drawing.Point(1158, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(39, 52);
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
            this.iconMini.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconMini.Location = new System.Drawing.Point(1113, 3);
            this.iconMini.Name = "iconMini";
            this.iconMini.Size = new System.Drawing.Size(39, 52);
            this.iconMini.TabIndex = 8;
            this.iconMini.UseVisualStyleBackColor = false;
            this.iconMini.Click += new System.EventHandler(this.iconMini_Click);
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
            this.iconCapture.Location = new System.Drawing.Point(403, 7);
            this.iconCapture.Name = "iconCapture";
            this.iconCapture.Size = new System.Drawing.Size(61, 52);
            this.iconCapture.TabIndex = 7;
            this.iconCapture.UseVisualStyleBackColor = false;
            this.iconCapture.Click += new System.EventHandler(this.iconCapture_Click);
            // 
            // IconIniciarCam
            // 
            this.IconIniciarCam.BackColor = System.Drawing.Color.Transparent;
            this.IconIniciarCam.FlatAppearance.BorderSize = 0;
            this.IconIniciarCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconIniciarCam.ForeColor = System.Drawing.Color.White;
            this.IconIniciarCam.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.IconIniciarCam.IconColor = System.Drawing.Color.White;
            this.IconIniciarCam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconIniciarCam.IconSize = 35;
            this.IconIniciarCam.Location = new System.Drawing.Point(336, 7);
            this.IconIniciarCam.Name = "IconIniciarCam";
            this.IconIniciarCam.Size = new System.Drawing.Size(61, 52);
            this.IconIniciarCam.TabIndex = 6;
            this.IconIniciarCam.UseVisualStyleBackColor = false;
            this.IconIniciarCam.Click += new System.EventHandler(this.IconIniciarCam_Click);
            // 
            // cbCamaraSelect
            // 
            this.cbCamaraSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCamaraSelect.BackColor = System.Drawing.Color.White;
            this.cbCamaraSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamaraSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCamaraSelect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamaraSelect.FormattingEnabled = true;
            this.cbCamaraSelect.Location = new System.Drawing.Point(52, 20);
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
            this.iconRefresh.Location = new System.Drawing.Point(3, 7);
            this.iconRefresh.Name = "iconRefresh";
            this.iconRefresh.Size = new System.Drawing.Size(43, 52);
            this.iconRefresh.TabIndex = 4;
            this.iconRefresh.UseVisualStyleBackColor = false;
            this.iconRefresh.Click += new System.EventHandler(this.iconRefresh_Click);
            // 
            // picCamara
            // 
            this.picCamara.BackColor = System.Drawing.Color.White;
            this.picCamara.Image = global::_2267CamaraProject.Properties.Resources.signal1;
            this.picCamara.Location = new System.Drawing.Point(14, 13);
            this.picCamara.Name = "picCamara";
            this.picCamara.Size = new System.Drawing.Size(1003, 434);
            this.picCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamara.TabIndex = 0;
            this.picCamara.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.picCamara);
            this.panel1.Location = new System.Drawing.Point(87, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 460);
            this.panel1.TabIndex = 2;
            // 
            // FrmCamaraMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 591);
            this.Controls.Add(this.topNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCamaraMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCamaraMonitor_FormClosed);
            this.topNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}

