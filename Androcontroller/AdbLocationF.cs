using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;
using Androcontroller.Properties;

namespace Androcontroller
{
    public partial class AdbLocationF : Form
    {
        public AdbLocationF()
        {
            InitializeComponent();
			SetText();
        }
		
		void SetText() {
			this.infoL.Text = "Para utilizar Androcontroller se necesita el archivo adb.exe.\r\nPor favor especifique la ruta en la que se encuentra:";
			this.searchB.Text = "Buscar";
			this.fileInfoL.Text = "El archivo adb.exe no se ha encontrado en la ruta por defecto";
			this.continueB.Text = "Continuar";
			this.downloadB.Text = "Descargar ADB automáticamente";
			this.cancelB.Text = "Cancelar";
			this.ofd.Title = "Elija el archivo adb.exe";
			this.Text = "Elegir ADB";

		}

        private void AdbLocationF_Load(object sender, EventArgs e)
        {
            adbLocationTB.Text = Properties.Settings.Default.AdbPath;
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
                adbLocationTB.Text = ofd.FileName;
        }

        private void adbLocationTB_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(adbLocationTB.Text))
                continueB.Enabled = true;
            else
                continueB.Enabled = false;
        }

        private void continueB_Click(object sender, EventArgs e)
        {
            adbLocationTB.Enabled = false;
            searchB.Enabled = false;

            Properties.Settings.Default.AdbPath = adbLocationTB.Text;
            Properties.Settings.Default.Save();

            Thread t = new Thread(new ThreadStart(GoMainF));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            this.Close();
        }

        void GoMainF() {
            Application.Run(new MainF());
        }

        #region Download

        private void downloadB_Click(object sender, EventArgs e)
        {
            adbLocationTB.Enabled = false;
            searchB.Enabled = false;
            
            Directory.CreateDirectory(Path.GetDirectoryName(Adb.AdbPath));

            StartDownload();
        }

        private void StartDownload()
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(
                    new Uri("http://lonamiwebs.github.io/_DOWNLOADS/software/ac_dependencies/ADB_Pack.zip"),
                    Path.GetTempPath() + @"\ADB_Pack.zip");
            });

            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = (double)e.BytesReceived;
                double totalBytes = (double)e.TotalBytesToReceive;
                double percentage = bytesIn / totalBytes * 100;
                
                fileInfoL.Text = Resources.DownADB + " " + e.ProgressPercentage + "%";
                int perc = (int)(Math.Truncate(percentage * 100d));
                downloadPB.Value = perc;
            });
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                fileInfoL.Text = Resources.DownComplete;
                Unzip();
                adbLocationTB.Text = Adb.AdbPath;
                continueB_Click(new object(), new EventArgs());
            });
        }

       void Unzip() {
           new ZipFile(Path.GetTempPath() + @"\ADB_Pack.zip")
               .ExtractAll(Path.GetDirectoryName(Adb.AdbPath));
       }

        #endregion
    }
}
