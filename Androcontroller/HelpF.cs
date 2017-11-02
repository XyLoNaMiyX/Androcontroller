using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Androcontroller
{
    public partial class HelpF : Form
    {
        public HelpF() { InitializeComponent(); SetText(); }
		
		void SetText() {
			this.Text = "Ayuda";
			this.acceptB.Text = "Aceptar";
			this.supportLL.Text = "lonamiwebs.github.io/contacto";
		}

        private void supportLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { Process.Start("http://lonamiwebs.github.io/contacto"); }

        private void acceptB_Click(object sender, EventArgs e) { this.Close(); }
    }
}
