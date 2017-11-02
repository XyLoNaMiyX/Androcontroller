namespace Androcontroller
{
    partial class AdbLocationF
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdbLocationF));
        	this.infoL = new System.Windows.Forms.Label();
        	this.adbLocationTB = new System.Windows.Forms.TextBox();
        	this.searchB = new System.Windows.Forms.Button();
        	this.fileInfoL = new System.Windows.Forms.Label();
        	this.continueB = new System.Windows.Forms.Button();
        	this.downloadPB = new System.Windows.Forms.ProgressBar();
        	this.downloadB = new System.Windows.Forms.Button();
        	this.cancelB = new System.Windows.Forms.Button();
        	this.ofd = new System.Windows.Forms.OpenFileDialog();
        	this.SuspendLayout();
        	// 
        	// infoL
        	// 
        	this.infoL.AutoSize = true;
        	this.infoL.Location = new System.Drawing.Point(12, 9);
        	this.infoL.Name = "infoL";
        	this.infoL.Size = new System.Drawing.Size(285, 26);
        	this.infoL.TabIndex = 0;
        	// 
        	// adbLocationTB
        	// 
        	this.adbLocationTB.Location = new System.Drawing.Point(13, 39);
        	this.adbLocationTB.Name = "adbLocationTB";
        	this.adbLocationTB.Size = new System.Drawing.Size(331, 20);
        	this.adbLocationTB.TabIndex = 1;
        	this.adbLocationTB.TextChanged += new System.EventHandler(this.adbLocationTB_TextChanged);
        	// 
        	// searchB
        	// 
        	this.searchB.Location = new System.Drawing.Point(350, 37);
        	this.searchB.Name = "searchB";
        	this.searchB.Size = new System.Drawing.Size(56, 23);
        	this.searchB.TabIndex = 2;
        	this.searchB.UseVisualStyleBackColor = true;
        	this.searchB.Click += new System.EventHandler(this.searchB_Click);
        	// 
        	// fileInfoL
        	// 
        	this.fileInfoL.AutoSize = true;
        	this.fileInfoL.Location = new System.Drawing.Point(13, 66);
        	this.fileInfoL.Name = "fileInfoL";
        	this.fileInfoL.Size = new System.Drawing.Size(300, 13);
        	this.fileInfoL.TabIndex = 3;
        	// 
        	// continueB
        	// 
        	this.continueB.Enabled = false;
        	this.continueB.Location = new System.Drawing.Point(340, 95);
        	this.continueB.Name = "continueB";
        	this.continueB.Size = new System.Drawing.Size(66, 23);
        	this.continueB.TabIndex = 4;
        	this.continueB.UseVisualStyleBackColor = true;
        	this.continueB.Click += new System.EventHandler(this.continueB_Click);
        	// 
        	// downloadPB
        	// 
        	this.downloadPB.Location = new System.Drawing.Point(4, 124);
        	this.downloadPB.Maximum = 10000;
        	this.downloadPB.Name = "downloadPB";
        	this.downloadPB.Size = new System.Drawing.Size(402, 23);
        	this.downloadPB.TabIndex = 5;
        	// 
        	// downloadB
        	// 
        	this.downloadB.Location = new System.Drawing.Point(121, 95);
        	this.downloadB.Name = "downloadB";
        	this.downloadB.Size = new System.Drawing.Size(176, 23);
        	this.downloadB.TabIndex = 6;
        	this.downloadB.UseVisualStyleBackColor = true;
        	this.downloadB.Click += new System.EventHandler(this.downloadB_Click);
        	// 
        	// cancelB
        	// 
        	this.cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.cancelB.Location = new System.Drawing.Point(4, 95);
        	this.cancelB.Name = "cancelB";
        	this.cancelB.Size = new System.Drawing.Size(62, 23);
        	this.cancelB.TabIndex = 7;
        	this.cancelB.UseVisualStyleBackColor = true;
        	// 
        	// ofd
        	// 
        	this.ofd.FileName = "adb.exe";
        	this.ofd.Filter = "ADB|adb.exe";
        	// 
        	// AdbLocationF
        	// 
        	this.AcceptButton = this.continueB;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.cancelB;
        	this.ClientSize = new System.Drawing.Size(409, 156);
        	this.Controls.Add(this.cancelB);
        	this.Controls.Add(this.downloadB);
        	this.Controls.Add(this.downloadPB);
        	this.Controls.Add(this.continueB);
        	this.Controls.Add(this.fileInfoL);
        	this.Controls.Add(this.searchB);
        	this.Controls.Add(this.adbLocationTB);
        	this.Controls.Add(this.infoL);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "AdbLocationF";
        	this.Load += new System.EventHandler(this.AdbLocationF_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label infoL;
        private System.Windows.Forms.TextBox adbLocationTB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Label fileInfoL;
        private System.Windows.Forms.Button continueB;
        private System.Windows.Forms.ProgressBar downloadPB;
        private System.Windows.Forms.Button downloadB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}
