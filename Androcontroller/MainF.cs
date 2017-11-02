using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Androcontroller.Properties;

namespace Androcontroller
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
			SetText();
        }
		
		void SetText() {
			this.welcomeL.Text = "Por favor elija un dispositivo para continuar:";
			this.refreshDeviceListB.Text = "Refrescar";
			this.selectDeviceB.Text = "Elegir dispositivo";
			this.deviceGB.Text = "Información del dispositivo";
			this.consoleL.Text = "Consola";
			this.moreInfoB.Text = "Ver más información del dispositivo";
			this.sendTextL.Text = "Enviar texto:";
			this.recordScreenCB.Text = "Capturar pantalla";
			this.toggleNotifB.Text = "Mostrar notificaciones";
			this.fpsL.Text = "FPS:";
			this.warningsL.Text = "[Avisos]";
			this.restartADB.Text = "Reiniciar ADB (si el dispositivo ha dejado de responder)";
			this.lonamiWebsLL.Text = "lonamiwebs.github.io";
			this.helpB.Text = "Ayuda";
			this.checkUpdatesB.Text = "Comprobar actualizaciones";
			this.spamL.Text = "Aplicación diseñada por:";
			this.Text = "Androcontroller";

		}

        #region Setup

        string device = "";

        void MainF_Load(object sender, EventArgs e)
        {	   	
            if (Settings.Default.AdbPath == "")
                Settings.Default.AdbPath = Adb.AdbPath;
            else
                Adb.AdbPath = Settings.Default.AdbPath;

            if (!File.Exists(Adb.AdbPath))
            {
                var t = new Thread(PromptAdbLocation);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();

                Close();
            }
            fpsNUD_ValueChanged(null, null);
            refreshDeviceListB_Click(null, null);
        }

        void PromptAdbLocation()
        {
            Application.Run(new AdbLocationF());
        }

        #endregion

        #region Select device and restart adb

        void devicesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (devicesLB.SelectedIndex < 0)
                selectDeviceB.Enabled = false;
            else
                selectDeviceB.Enabled = true;
        }

        void devicesLB_DoubleClick(object sender, EventArgs e)
        {
            if (selectDeviceB.Enabled)
                selectDeviceB_Click(new object(), new EventArgs());
        }

        void refreshDeviceListB_Click(object sender, EventArgs e)
        {
            devicesLB.Items.Clear();
            foreach (string dev in GetDevicesSync())
                devicesLB.Items.Add(dev);
        }

        void selectDeviceB_Click(object sender, EventArgs e)
        {
            try
            {
                device = devicesLB.SelectedItem.ToString();
                deviceGB.Text = device + Resources.Con;
                deviceGB.Enabled = true;
            }
            catch (NullReferenceException)
            {
                warningsL.Text = Resources.WarnCNC;
            }
        }

        void restartADB_Click(object sender, EventArgs e)
        {
            Adb.RestartADB();
        }

        #endregion

        #region Device information

        string[] GetDevicesSync()
        {
        	if (!File.Exists(Adb.AdbPath))
        		return new string[0];
        	
            //to get superuser permission, send first of all su command (with WriteLine in proccess perhaps?)
            // $ shell su command 

            string all = Adb.UseADBCommand("devices");
            string[] lines = all.Split(new[] {"\r\n"}, StringSplitOptions.None);

            int devcount = 0;
            foreach (string line in lines)
                if (line.Contains("device") && !line.Contains("devices"))
                    devcount++;

            var devices = new string[devcount];

            int j = 0;
            for (int i = 0; i < lines.Length; i++)
                if (lines[i].Contains("device") && !lines[i].Contains("devices"))
                {
                    devices[j] = lines[i].Split('\t')[0];
                    j++;
                }

            return devices;
        }

        #endregion

        #region Android control

        bool foundSize;
        int screenHeight;
        int screenWidth;

        #region Record screen

        void fpsNUD_ValueChanged(object sender, EventArgs e)
        {
            if (fpsNUD.Value > 1.2m)
            {
                if (MessageBox.Show(Resources.WarnHighFPS, Resources.WarnHighFPST,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    fpsNUD.Value = 1.2m;
                    return;
                }
            }
            
            
            decimal milliseconds = 1000/fpsNUD.Value;
            capScreenT.Interval = (int) milliseconds;
        }

        void captureScreenCB_CheckedChanged(object sender, EventArgs e)
        {
            capScreenT.Enabled = recordScreenCB.Checked;
            if (!capScreenT.Enabled)
                screenPB.Image = null;
        }

        async Task<Image> CaptureScreen()
        {
            //acsc = AndroidControllerScreenCaptures
            string dir = Path.GetTempPath() + @"\acsc\";
            Directory.CreateDirectory(dir);

            string path = dir + Guid.NewGuid() + ".png";

            string[] commands =
            {
                // i'm sure i'll have to tweak the path (for other devices)
                "shell screencap -p /storage/sdcard0/screen.png",
                "pull /storage/sdcard0/screen.png " + path
            };

            await Adb.UseADBCommandAsync(commands, device);

            try
            {
                Image image = Image.FromFile(path);
                return image;
            }
            catch (OutOfMemoryException)
            {
                warningsL.Text = Resources.WarnTooFPS;
                warningsL.ForeColor = warningsL.ForeColor == Color.Black ? Color.Red : Color.Black;

                Adb.RestartADB();

                return null;
            }
        }

        async void capScreenT_Tick(object sender, EventArgs e)
        {
            if (capScreenT.Enabled)
            {
                Image image = await CaptureScreen();
                screenPB.Image = image;

                if (foundSize)
                    return;
                screenWidth = image.Width;
                screenHeight = image.Height;
                foundSize = true;
            }
            else
            {
                screenPB.Image = null;
            }
        }

        #endregion

        #region Shortcuts

        async void toggleNotifB_Click(object sender, EventArgs e)
        {
            await Adb.UseADBCommandAsync("shell input swipe 10 10 10 1000", device);
        }

        #endregion

        #region Send text

        void sendTextTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Adb.UseADBCommand("shell input text '" +
                                  sendTextTB.Text.Replace(" ", "%s").Replace(@"""", @"\""") + "'", device);
                sendTextTB.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region Tap and swipe

        Point endPoint;
        Point enterPoint;

        void screenPB_MouseDown(object sender, MouseEventArgs e)
        {
            enterPoint = GetLocation(e.Location);
        }

        async void screenPB_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = GetLocation(e.Location);

            if (enterPoint == endPoint)
                await Adb.UseADBCommandAsync("shell input tap " + endPoint.X + " " + endPoint.Y, device);
            else
                await Adb.UseADBCommandAsync("shell input swipe " + enterPoint.X + " " + enterPoint.Y +
                                             " " + endPoint.X + " " + endPoint.Y, device);
        }

        Point GetLocation(Point mouseLocation)
        {
            if (foundSize)
            {
                int x = screenWidth*mouseLocation.X/screenPB.Width;
                int y = screenHeight*mouseLocation.Y/screenPB.Height;
                return new Point(x, y);
            }

            return mouseLocation;
        }

        #endregion

        #region Physical Buttons

        //http://www.guidingtech.com/15008/adb-control-keypress-broken-android-keys/

        async void menuB_Click(object sender, EventArgs e)
        {
            await Adb.UseADBCommandAsync("shell input keyevent 82", device);
        }

        async void homeB_Click(object sender, EventArgs e)
        {
            await Adb.UseADBCommandAsync("shell input keyevent 3", device);
        }

        async void backB_Click(object sender, EventArgs e)
        {
            await Adb.UseADBCommandAsync("shell input keyevent 4", device);
        }

        async void volumeUpB_Click(object sender, EventArgs e)
        {
            await Adb.UseADBCommandAsync("shell input keyevent 24", device);
        }

        async void volumeDownB_Click(object sender, EventArgs e)
        {
            await Adb.UseADBCommandAsync("shell input keyevent 25", device);
        }

        async void powerB_Click(object sender, EventArgs e)
        {
            await Adb.UseADBCommandAsync("shell input keyevent 26", device);
        }

        #endregion

        #region More info and console

        void moreInfoB_Click(object sender, EventArgs e)
        {
            new DeviceInfoF(device).Show();
        }

        void consoleInputTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                consoleTB.Text += Adb.UseADBCommand(consoleInputTB.Text, device) + "\r\n";
                consoleInputTB.Clear();
            }
        }

        #endregion

        #endregion

        #region Wiping cache

        void MainF_FormClosing(object sender, FormClosingEventArgs e)
        {
        	Adb.RestartADB();
            recordScreenCB.Checked = false;
            string dir = Path.GetTempPath() + @"\acsc";
            if (Directory.Exists(dir))
                try {
                    Directory.Delete(dir, true);
                } catch (IOException) { }
        }

        #endregion

        #region Others

        void lonamiWebsLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://lonamiwebs.github.io");
        }

        #endregion

        void helpB_Click(object sender, EventArgs e)
        {
            new HelpF().Show();
        }

        void checkUpdatesB_Click(object sender, EventArgs e)
        {
            new UpdateChecker.UpdateChecker(Assembly.GetExecutingAssembly().Location, "ac").Show();
        }
    }

    public static class Adb
    {
        public static string AdbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                                       @"\Android\android-sdk\platform-tools\adb.exe";

        #region Sync

        public static string UseADBCommand(string command, string device = "")
        {
            return UseADBCommand(new[] {command}, device);
        }

        public static string UseADBCommand(string[] commands, string device)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = AdbPath;
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.RedirectStandardOutput = true;

            string output = "";

            foreach (string command in commands)
            {
                if (device == "")
                    psi.Arguments = command;
                else
                    psi.Arguments = "-s " + device + " " + command;

                var p = new Process();
                p.StartInfo = psi;
                p.Start();

                StreamReader sr = p.StandardOutput;
                output += sr.ReadToEnd() + "\r\n";

                p.WaitForExit();
            }

            return output;
        }

        #endregion

        #region Async

        public static async Task UseADBCommandAsync(string command, string device)
        {
            await UseADBCommandAsync(new[] {command}, device);
        }

        public static async Task UseADBCommandAsync(string[] commands, string device)
        {
            //to get superuser permission, send first of all su command (with WriteLine in proccess perhaps?)
            // $ shell su command

            var psi = new ProcessStartInfo();
            psi.FileName = AdbPath;
            psi.CreateNoWindow = true;
            psi.UseShellExecute = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;

            foreach (string command in commands)
            {
                psi.Arguments = "-s " + device + " " + command;
                await RunADBAsync(psi);
            }
        }

        static Task RunADBAsync(ProcessStartInfo psi)
        {
            var tcs = new TaskCompletionSource<bool>();

            var process = new Process
            {
                StartInfo = psi,
                EnableRaisingEvents = true
            };

            process.Exited += (sender, args) =>
            {
                tcs.SetResult(true);
                process.Dispose();
            };

            process.Start();

            return tcs.Task;
        }

        #endregion

        public static void RestartADB()
        {
            foreach (Process proc in Process.GetProcessesByName("adb.exe"))
                proc.Kill();
        }
    }
}
