namespace Androcontroller
{
    partial class HelpF
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpF));
        	this.label1 = new System.Windows.Forms.Label();
        	this.supportLL = new System.Windows.Forms.LinkLabel();
        	this.acceptB = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(13, 13);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(590, 78);
        	this.label1.TabIndex = 0;
        	this.label1.Text = resources.GetString("label1.Text");
        	// 
        	// supportLL
        	// 
        	this.supportLL.AutoSize = true;
        	this.supportLL.Location = new System.Drawing.Point(13, 101);
        	this.supportLL.Name = "supportLL";
        	this.supportLL.Size = new System.Drawing.Size(133, 13);
        	this.supportLL.TabIndex = 1;
        	this.supportLL.TabStop = true;
        	this.supportLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.supportLL_LinkClicked);
        	// 
        	// acceptB
        	// 
        	this.acceptB.Location = new System.Drawing.Point(546, 108);
        	this.acceptB.Name = "acceptB";
        	this.acceptB.Size = new System.Drawing.Size(57, 23);
        	this.acceptB.TabIndex = 2;
        	this.acceptB.UseVisualStyleBackColor = true;
        	this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
        	// 
        	// HelpF
        	// 
        	this.AcceptButton = this.acceptB;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(607, 138);
        	this.Controls.Add(this.acceptB);
        	this.Controls.Add(this.supportLL);
        	this.Controls.Add(this.label1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "help";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel supportLL;
        private System.Windows.Forms.Button acceptB;
    }
}
