namespace Androcontroller
{
    partial class DeviceInfoF
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceInfoF));
        	this.availableInfoLB = new System.Windows.Forms.ListBox();
        	this.viewInfoL = new System.Windows.Forms.Label();
        	this.informationTB = new System.Windows.Forms.TextBox();
        	this.refreshB = new System.Windows.Forms.Button();
        	this.refreshT = new System.Windows.Forms.Timer(this.components);
        	this.autorefreshCB = new System.Windows.Forms.CheckBox();
        	this.autorefreshNUD = new System.Windows.Forms.NumericUpDown();
        	this.autorefreshL = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.autorefreshNUD)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// availableInfoLB
        	// 
        	this.availableInfoLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
        	this.availableInfoLB.FormattingEnabled = true;
        	this.availableInfoLB.Location = new System.Drawing.Point(12, 29);
        	this.availableInfoLB.Name = "availableInfoLB";
        	this.availableInfoLB.Size = new System.Drawing.Size(160, 329);
        	this.availableInfoLB.TabIndex = 0;
        	this.availableInfoLB.SelectedIndexChanged += new System.EventHandler(this.availableInfoLB_SelectedIndexChanged);
        	// 
        	// viewInfoL
        	// 
        	this.viewInfoL.AutoSize = true;
        	this.viewInfoL.Location = new System.Drawing.Point(13, 13);
        	this.viewInfoL.Name = "viewInfoL";
        	this.viewInfoL.Size = new System.Drawing.Size(98, 13);
        	this.viewInfoL.TabIndex = 1;
        	// 
        	// informationTB
        	// 
        	this.informationTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.informationTB.Location = new System.Drawing.Point(178, 13);
        	this.informationTB.Multiline = true;
        	this.informationTB.Name = "informationTB";
        	this.informationTB.ReadOnly = true;
        	this.informationTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.informationTB.Size = new System.Drawing.Size(511, 314);
        	this.informationTB.TabIndex = 2;
        	// 
        	// refreshB
        	// 
        	this.refreshB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.refreshB.Location = new System.Drawing.Point(625, 333);
        	this.refreshB.Name = "refresh";
        	this.refreshB.Size = new System.Drawing.Size(64, 23);
        	this.refreshB.TabIndex = 3;
        	this.refreshB.UseVisualStyleBackColor = true;
        	this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
        	// 
        	// refreshT
        	// 
        	this.refreshT.Tick += new System.EventHandler(this.refreshT_Tick);
        	// 
        	// autorefreshCB
        	// 
        	this.autorefreshCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.autorefreshCB.AutoSize = true;
        	this.autorefreshCB.Location = new System.Drawing.Point(178, 337);
        	this.autorefreshCB.Name = "autorefreshCB";
        	this.autorefreshCB.Size = new System.Drawing.Size(116, 17);
        	this.autorefreshCB.TabIndex = 4;
        	this.autorefreshCB.UseVisualStyleBackColor = true;
        	this.autorefreshCB.CheckedChanged += new System.EventHandler(this.autorefreshCB_CheckedChanged);
        	// 
        	// autorefreshNUD
        	// 
        	this.autorefreshNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.autorefreshNUD.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
        	this.autorefreshNUD.Location = new System.Drawing.Point(289, 336);
        	this.autorefreshNUD.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
        	this.autorefreshNUD.Minimum = new decimal(new int[] {
			50,
			0,
			0,
			0});
        	this.autorefreshNUD.Name = "autorefreshNUD";
        	this.autorefreshNUD.Size = new System.Drawing.Size(62, 20);
        	this.autorefreshNUD.TabIndex = 5;
        	this.autorefreshNUD.Value = new decimal(new int[] {
			100,
			0,
			0,
			0});
        	this.autorefreshNUD.ValueChanged += new System.EventHandler(this.autorefreshNUD_ValueChanged);
        	// 
        	// autorefreshL
        	// 
        	this.autorefreshL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.autorefreshL.AutoSize = true;
        	this.autorefreshL.Location = new System.Drawing.Point(357, 339);
        	this.autorefreshL.Name = "autorefreshL";
        	this.autorefreshL.Size = new System.Drawing.Size(67, 13);
        	this.autorefreshL.TabIndex = 6;
        	// 
        	// DeviceInfoF
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(704, 361);
        	this.Controls.Add(this.autorefreshL);
        	this.Controls.Add(this.autorefreshNUD);
        	this.Controls.Add(this.autorefreshCB);
        	this.Controls.Add(this.refreshB);
        	this.Controls.Add(this.informationTB);
        	this.Controls.Add(this.viewInfoL);
        	this.Controls.Add(this.availableInfoLB);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MinimumSize = new System.Drawing.Size(520, 190);
        	this.Name = "deviceInfo";
        	this.Load += new System.EventHandler(this.DeviceInfoF_Load);
        	((System.ComponentModel.ISupportInitialize)(this.autorefreshNUD)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availableInfoLB;
        private System.Windows.Forms.Label viewInfoL;
        private System.Windows.Forms.TextBox informationTB;
        private System.Windows.Forms.Button refreshB;
        private System.Windows.Forms.Timer refreshT;
        private System.Windows.Forms.CheckBox autorefreshCB;
        private System.Windows.Forms.NumericUpDown autorefreshNUD;
        private System.Windows.Forms.Label autorefreshL;
    }
}
