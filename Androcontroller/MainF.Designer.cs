namespace Androcontroller
{
    partial class MainF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name=Strings.str6>true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
        	this.welcomeL = new System.Windows.Forms.Label();
        	this.devicesLB = new System.Windows.Forms.ListBox();
        	this.refreshDeviceListB = new System.Windows.Forms.Button();
        	this.selectDeviceB = new System.Windows.Forms.Button();
        	this.deviceGB = new System.Windows.Forms.GroupBox();
        	this.consoleInputTB = new System.Windows.Forms.TextBox();
        	this.consoleL = new System.Windows.Forms.Label();
        	this.consoleTB = new System.Windows.Forms.TextBox();
        	this.moreInfoB = new System.Windows.Forms.Button();
        	this.physicalButtonsP = new System.Windows.Forms.Panel();
        	this.volumeDownB = new System.Windows.Forms.Button();
        	this.volumeUpB = new System.Windows.Forms.Button();
        	this.sendTextL = new System.Windows.Forms.Label();
        	this.homeB = new System.Windows.Forms.Button();
        	this.sendTextTB = new System.Windows.Forms.TextBox();
        	this.menuB = new System.Windows.Forms.Button();
        	this.backB = new System.Windows.Forms.Button();
        	this.recordScreenCB = new System.Windows.Forms.CheckBox();
        	this.toggleNotifB = new System.Windows.Forms.Button();
        	this.fpsNUD = new System.Windows.Forms.NumericUpDown();
        	this.powerB = new System.Windows.Forms.Button();
        	this.fpsL = new System.Windows.Forms.Label();
        	this.screenPB = new System.Windows.Forms.PictureBox();
        	this.capScreenT = new System.Windows.Forms.Timer(this.components);
        	this.warningsL = new System.Windows.Forms.Label();
        	this.restartADB = new System.Windows.Forms.Button();
        	this.lonamiWebsLL = new System.Windows.Forms.LinkLabel();
        	this.helpB = new System.Windows.Forms.Button();
        	this.checkUpdatesB = new System.Windows.Forms.Button();
        	this.spamL = new System.Windows.Forms.Label();
        	this.deviceGB.SuspendLayout();
        	this.physicalButtonsP.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.fpsNUD)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.screenPB)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// welcomeL
        	// 
        	this.welcomeL.AutoSize = true;
        	this.welcomeL.Location = new System.Drawing.Point(13, 13);
        	this.welcomeL.Name = "welcomeL";
        	this.welcomeL.Size = new System.Drawing.Size(212, 13);
        	this.welcomeL.TabIndex = 0;
        	// 
        	// devicesLB
        	// 
        	this.devicesLB.FormattingEnabled = true;
        	this.devicesLB.Location = new System.Drawing.Point(16, 29);
        	this.devicesLB.Name = "devicesLB";
        	this.devicesLB.Size = new System.Drawing.Size(209, 95);
        	this.devicesLB.TabIndex = 1;
        	this.devicesLB.SelectedIndexChanged += new System.EventHandler(this.devicesLB_SelectedIndexChanged);
        	this.devicesLB.DoubleClick += new System.EventHandler(this.devicesLB_DoubleClick);
        	// 
        	// refreshDeviceListB
        	// 
        	this.refreshDeviceListB.Location = new System.Drawing.Point(16, 131);
        	this.refreshDeviceListB.Name = "refresh";
        	this.refreshDeviceListB.Size = new System.Drawing.Size(65, 23);
        	this.refreshDeviceListB.TabIndex = 2;
        	this.refreshDeviceListB.UseVisualStyleBackColor = true;
        	this.refreshDeviceListB.Click += new System.EventHandler(this.refreshDeviceListB_Click);
        	// 
        	// selectDeviceB
        	// 
        	this.selectDeviceB.Enabled = false;
        	this.selectDeviceB.Location = new System.Drawing.Point(124, 131);
        	this.selectDeviceB.Name = "selectDeviceB";
        	this.selectDeviceB.Size = new System.Drawing.Size(101, 23);
        	this.selectDeviceB.TabIndex = 3;
        	this.selectDeviceB.UseVisualStyleBackColor = true;
        	this.selectDeviceB.Click += new System.EventHandler(this.selectDeviceB_Click);
        	// 
        	// deviceGB
        	// 
        	this.deviceGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.deviceGB.Controls.Add(this.consoleInputTB);
        	this.deviceGB.Controls.Add(this.consoleL);
        	this.deviceGB.Controls.Add(this.consoleTB);
        	this.deviceGB.Controls.Add(this.moreInfoB);
        	this.deviceGB.Controls.Add(this.physicalButtonsP);
        	this.deviceGB.Controls.Add(this.screenPB);
        	this.deviceGB.Enabled = false;
        	this.deviceGB.Location = new System.Drawing.Point(231, 12);
        	this.deviceGB.Name = "deviceInfo";
        	this.deviceGB.Size = new System.Drawing.Size(550, 510);
        	this.deviceGB.TabIndex = 4;
        	this.deviceGB.TabStop = false;
        	// 
        	// consoleInputTB
        	// 
        	this.consoleInputTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.consoleInputTB.Location = new System.Drawing.Point(6, 481);
        	this.consoleInputTB.Name = "consoleInputTB";
        	this.consoleInputTB.Size = new System.Drawing.Size(212, 20);
        	this.consoleInputTB.TabIndex = 16;
        	this.consoleInputTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleInputTB_KeyDown);
        	// 
        	// consoleL
        	// 
        	this.consoleL.AutoSize = true;
        	this.consoleL.Location = new System.Drawing.Point(9, 332);
        	this.consoleL.Name = "consoleL";
        	this.consoleL.Size = new System.Drawing.Size(45, 13);
        	this.consoleL.TabIndex = 15;
        	// 
        	// consoleTB
        	// 
        	this.consoleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
        	this.consoleTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        	this.consoleTB.ForeColor = System.Drawing.Color.Lime;
        	this.consoleTB.Location = new System.Drawing.Point(6, 348);
        	this.consoleTB.Multiline = true;
        	this.consoleTB.Name = "consoleTB";
        	this.consoleTB.ReadOnly = true;
        	this.consoleTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.consoleTB.Size = new System.Drawing.Size(212, 127);
        	this.consoleTB.TabIndex = 14;
        	// 
        	// moreInfoB
        	// 
        	this.moreInfoB.Location = new System.Drawing.Point(6, 306);
        	this.moreInfoB.Name = "moreInfoB";
        	this.moreInfoB.Size = new System.Drawing.Size(200, 23);
        	this.moreInfoB.TabIndex = 13;
        	this.moreInfoB.UseVisualStyleBackColor = true;
        	this.moreInfoB.Click += new System.EventHandler(this.moreInfoB_Click);
        	// 
        	// physicalButtonsP
        	// 
        	this.physicalButtonsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        	this.physicalButtonsP.Controls.Add(this.volumeDownB);
        	this.physicalButtonsP.Controls.Add(this.volumeUpB);
        	this.physicalButtonsP.Controls.Add(this.sendTextL);
        	this.physicalButtonsP.Controls.Add(this.homeB);
        	this.physicalButtonsP.Controls.Add(this.sendTextTB);
        	this.physicalButtonsP.Controls.Add(this.menuB);
        	this.physicalButtonsP.Controls.Add(this.backB);
        	this.physicalButtonsP.Controls.Add(this.recordScreenCB);
        	this.physicalButtonsP.Controls.Add(this.toggleNotifB);
        	this.physicalButtonsP.Controls.Add(this.fpsNUD);
        	this.physicalButtonsP.Controls.Add(this.powerB);
        	this.physicalButtonsP.Controls.Add(this.fpsL);
        	this.physicalButtonsP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.physicalButtonsP.Location = new System.Drawing.Point(6, 20);
        	this.physicalButtonsP.Name = "physicalButtonsP";
        	this.physicalButtonsP.Size = new System.Drawing.Size(200, 280);
        	this.physicalButtonsP.TabIndex = 12;
        	// 
        	// volumeDownB
        	// 
        	this.volumeDownB.BackgroundImage = global::Androcontroller.Properties.Resources.VolumeDown;
        	this.volumeDownB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.volumeDownB.Location = new System.Drawing.Point(4, 95);
        	this.volumeDownB.Name = "volumeDownB";
        	this.volumeDownB.Size = new System.Drawing.Size(42, 42);
        	this.volumeDownB.TabIndex = 16;
        	this.volumeDownB.UseVisualStyleBackColor = true;
        	this.volumeDownB.Click += new System.EventHandler(this.volumeDownB_Click);
        	// 
        	// volumeUpB
        	// 
        	this.volumeUpB.BackgroundImage = global::Androcontroller.Properties.Resources.VolumeUp;
        	this.volumeUpB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.volumeUpB.Location = new System.Drawing.Point(4, 46);
        	this.volumeUpB.Name = "volumeUpB";
        	this.volumeUpB.Size = new System.Drawing.Size(42, 42);
        	this.volumeUpB.TabIndex = 15;
        	this.volumeUpB.UseVisualStyleBackColor = true;
        	this.volumeUpB.Click += new System.EventHandler(this.volumeUpB_Click);
        	// 
        	// sendTextL
        	// 
        	this.sendTextL.AutoSize = true;
        	this.sendTextL.Location = new System.Drawing.Point(3, 193);
        	this.sendTextL.Name = "sendTextL";
        	this.sendTextL.Size = new System.Drawing.Size(66, 13);
        	this.sendTextL.TabIndex = 13;
        	// 
        	// homeB
        	// 
        	this.homeB.BackgroundImage = global::Androcontroller.Properties.Resources.Home;
        	this.homeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.homeB.Location = new System.Drawing.Point(83, 235);
        	this.homeB.Name = "homeB";
        	this.homeB.Size = new System.Drawing.Size(42, 42);
        	this.homeB.TabIndex = 13;
        	this.homeB.UseVisualStyleBackColor = true;
        	this.homeB.Click += new System.EventHandler(this.homeB_Click);
        	// 
        	// sendTextTB
        	// 
        	this.sendTextTB.Location = new System.Drawing.Point(2, 209);
        	this.sendTextTB.Name = "sendTextTB";
        	this.sendTextTB.Size = new System.Drawing.Size(195, 20);
        	this.sendTextTB.TabIndex = 9;
        	this.sendTextTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendTextTB_KeyDown);
        	// 
        	// menuB
        	// 
        	this.menuB.BackgroundImage = global::Androcontroller.Properties.Resources.Menu;
        	this.menuB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.menuB.Location = new System.Drawing.Point(3, 235);
        	this.menuB.Name = "menuB";
        	this.menuB.Size = new System.Drawing.Size(42, 42);
        	this.menuB.TabIndex = 14;
        	this.menuB.UseVisualStyleBackColor = true;
        	this.menuB.Click += new System.EventHandler(this.menuB_Click);
        	// 
        	// backB
        	// 
        	this.backB.BackgroundImage = global::Androcontroller.Properties.Resources.Back;
        	this.backB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.backB.Location = new System.Drawing.Point(155, 235);
        	this.backB.Name = "backB";
        	this.backB.Size = new System.Drawing.Size(42, 42);
        	this.backB.TabIndex = 11;
        	this.backB.UseVisualStyleBackColor = true;
        	this.backB.Click += new System.EventHandler(this.backB_Click);
        	// 
        	// recordScreenCB
        	// 
        	this.recordScreenCB.AutoSize = true;
        	this.recordScreenCB.Location = new System.Drawing.Point(66, 131);
        	this.recordScreenCB.Name = "recordScreenCB";
        	this.recordScreenCB.Size = new System.Drawing.Size(106, 17);
        	this.recordScreenCB.TabIndex = 7;
        	this.recordScreenCB.UseVisualStyleBackColor = true;
        	this.recordScreenCB.CheckedChanged += new System.EventHandler(this.captureScreenCB_CheckedChanged);
        	// 
        	// toggleNotifB
        	// 
        	this.toggleNotifB.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.toggleNotifB.Location = new System.Drawing.Point(3, 3);
        	this.toggleNotifB.Name = "toggleNotifB";
        	this.toggleNotifB.Size = new System.Drawing.Size(122, 23);
        	this.toggleNotifB.TabIndex = 8;
        	this.toggleNotifB.UseVisualStyleBackColor = true;
        	this.toggleNotifB.Click += new System.EventHandler(this.toggleNotifB_Click);
        	// 
        	// fpsNUD
        	// 
        	this.fpsNUD.DecimalPlaces = 1;
        	this.fpsNUD.Increment = new decimal(new int[] {
			1,
			0,
			0,
			65536});
        	this.fpsNUD.Location = new System.Drawing.Point(91, 104);
        	this.fpsNUD.Maximum = new decimal(new int[] {
			60,
			0,
			0,
			0});
        	this.fpsNUD.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			65536});
        	this.fpsNUD.Name = "fpsNUD";
        	this.fpsNUD.Size = new System.Drawing.Size(60, 20);
        	this.fpsNUD.TabIndex = 6;
        	this.fpsNUD.Value = new decimal(new int[] {
			8,
			0,
			0,
			65536});
        	this.fpsNUD.ValueChanged += new System.EventHandler(this.fpsNUD_ValueChanged);
        	// 
        	// powerB
        	// 
        	this.powerB.BackgroundImage = global::Androcontroller.Properties.Resources.Power;
        	this.powerB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.powerB.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.powerB.Location = new System.Drawing.Point(149, 3);
        	this.powerB.Name = "powerB";
        	this.powerB.Size = new System.Drawing.Size(48, 48);
        	this.powerB.TabIndex = 10;
        	this.powerB.UseVisualStyleBackColor = true;
        	this.powerB.Click += new System.EventHandler(this.powerB_Click);
        	// 
        	// fpsL
        	// 
        	this.fpsL.AutoSize = true;
        	this.fpsL.Location = new System.Drawing.Point(63, 106);
        	this.fpsL.Name = "fpsL";
        	this.fpsL.Size = new System.Drawing.Size(30, 13);
        	this.fpsL.TabIndex = 5;
        	// 
        	// screenPB
        	// 
        	this.screenPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.screenPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        	this.screenPB.Location = new System.Drawing.Point(224, 19);
        	this.screenPB.Name = "screenPB";
        	this.screenPB.Size = new System.Drawing.Size(320, 480);
        	this.screenPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.screenPB.TabIndex = 4;
        	this.screenPB.TabStop = false;
        	this.screenPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.screenPB_MouseDown);
        	this.screenPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.screenPB_MouseUp);
        	// 
        	// capScreenT
        	// 
        	this.capScreenT.Tick += new System.EventHandler(this.capScreenT_Tick);
        	// 
        	// warningsL
        	// 
        	this.warningsL.AutoSize = true;
        	this.warningsL.Location = new System.Drawing.Point(9, 200);
        	this.warningsL.Name = "warningsL";
        	this.warningsL.Size = new System.Drawing.Size(44, 13);
        	this.warningsL.TabIndex = 5;
        	// 
        	// restartADB
        	// 
        	this.restartADB.BackColor = System.Drawing.SystemColors.Control;
        	this.restartADB.Location = new System.Drawing.Point(12, 160);
        	this.restartADB.Name = "restartADB";
        	this.restartADB.Size = new System.Drawing.Size(213, 37);
        	this.restartADB.TabIndex = 13;
        	this.restartADB.UseVisualStyleBackColor = false;
        	this.restartADB.Click += new System.EventHandler(this.restartADB_Click);
        	// 
        	// lonamiWebsLL
        	// 
        	this.lonamiWebsLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.lonamiWebsLL.AutoSize = true;
        	this.lonamiWebsLL.Location = new System.Drawing.Point(139, 474);
        	this.lonamiWebsLL.Name = "lonamiWebsLL";
        	this.lonamiWebsLL.Size = new System.Drawing.Size(86, 13);
        	this.lonamiWebsLL.TabIndex = 14;
        	this.lonamiWebsLL.TabStop = true;
        	this.lonamiWebsLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lonamiWebsLL_LinkClicked);
        	// 
        	// helpB
        	// 
        	this.helpB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.helpB.Location = new System.Drawing.Point(7, 493);
        	this.helpB.Name = "help";
        	this.helpB.Size = new System.Drawing.Size(49, 23);
        	this.helpB.TabIndex = 15;
        	this.helpB.UseVisualStyleBackColor = true;
        	this.helpB.Click += new System.EventHandler(this.helpB_Click);
        	// 
        	// checkUpdatesB
        	// 
        	this.checkUpdatesB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.checkUpdatesB.Location = new System.Drawing.Point(76, 493);
        	this.checkUpdatesB.Name = "checkUpdatesB";
        	this.checkUpdatesB.Size = new System.Drawing.Size(149, 23);
        	this.checkUpdatesB.TabIndex = 16;
        	this.checkUpdatesB.UseVisualStyleBackColor = true;
        	this.checkUpdatesB.Click += new System.EventHandler(this.checkUpdatesB_Click);
        	// 
        	// spamL
        	// 
        	this.spamL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.spamL.AutoSize = true;
        	this.spamL.Location = new System.Drawing.Point(9, 474);
        	this.spamL.Name = "spamL";
        	this.spamL.Size = new System.Drawing.Size(123, 13);
        	this.spamL.TabIndex = 17;
        	// 
        	// MainF
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(784, 531);
        	this.Controls.Add(this.spamL);
        	this.Controls.Add(this.checkUpdatesB);
        	this.Controls.Add(this.helpB);
        	this.Controls.Add(this.lonamiWebsLL);
        	this.Controls.Add(this.restartADB);
        	this.Controls.Add(this.warningsL);
        	this.Controls.Add(this.deviceGB);
        	this.Controls.Add(this.selectDeviceB);
        	this.Controls.Add(this.refreshDeviceListB);
        	this.Controls.Add(this.devicesLB);
        	this.Controls.Add(this.welcomeL);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MinimumSize = new System.Drawing.Size(640, 500);
        	this.Name = "MainF";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainF_FormClosing);
        	this.Load += new System.EventHandler(this.MainF_Load);
        	this.deviceGB.ResumeLayout(false);
        	this.deviceGB.PerformLayout();
        	this.physicalButtonsP.ResumeLayout(false);
        	this.physicalButtonsP.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.fpsNUD)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.screenPB)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeL;
        private System.Windows.Forms.ListBox devicesLB;
        private System.Windows.Forms.Button refreshDeviceListB;
        private System.Windows.Forms.Button selectDeviceB;
        private System.Windows.Forms.GroupBox deviceGB;
        private System.Windows.Forms.PictureBox screenPB;
        private System.Windows.Forms.NumericUpDown fpsNUD;
        private System.Windows.Forms.Label fpsL;
        private System.Windows.Forms.Timer capScreenT;
        private System.Windows.Forms.CheckBox recordScreenCB;
        private System.Windows.Forms.Button toggleNotifB;
        private System.Windows.Forms.TextBox sendTextTB;
        private System.Windows.Forms.Label warningsL;
        private System.Windows.Forms.Button powerB;
        private System.Windows.Forms.Button menuB;
        private System.Windows.Forms.Button homeB;
        private System.Windows.Forms.Panel physicalButtonsP;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Label sendTextL;
        private System.Windows.Forms.Button restartADB;
        private System.Windows.Forms.Button volumeUpB;
        private System.Windows.Forms.Button volumeDownB;
        private System.Windows.Forms.Button moreInfoB;
        private System.Windows.Forms.LinkLabel lonamiWebsLL;
        private System.Windows.Forms.TextBox consoleInputTB;
        private System.Windows.Forms.Label consoleL;
        private System.Windows.Forms.TextBox consoleTB;
        private System.Windows.Forms.Button helpB;
        private System.Windows.Forms.Button checkUpdatesB;
        private System.Windows.Forms.Label spamL;
    }
}
