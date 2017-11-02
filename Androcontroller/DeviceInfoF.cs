using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Androcontroller
{
    public partial class DeviceInfoF : Form
    {
        public DeviceInfoF(string dev = "")
        {
            InitializeComponent();
			SetText();
			
            device = dev;
        }
		
		void SetText() {
			this.availableInfoLB.Items.AddRange(new object[] {
			"Accesibilidad [accessibility]",
			"Cuenta [account]",
			"Actividad [activity]",
			"Alarma [alarm]",
			"Widget de aplicación [appwidget]",
			"Audio [audio]",
			"Copia de seguridad [backup]",
			"Batería [battery]",
			"Información  de la batería [batteryinfo]",
			"Portapapeles [clipboard]",
			"Conectividad [connectivity]",
			"Contenido [content]",
			"Información de la CPU [cpuinfo]",
			"Política del dispositivo [device_policy]",
			"Monitor de almacenamiento[devicestoragemonitor]",
			"Estado del disco [diskstats]",
			"Dropbox [dropbox]",
			"Entropy [entropy]",
			"Hardware [hardware]",
			"Método de entrada [input_method]",
			"Sub información iPhone [iphonesubinfo]",
			"ISMS [isms]",
			"Localización [location]",
			"Deflector de audio [media.audio_flinger]",
			"Política del audio [media.audio_policy]",
			"Reproductor multimedia [media.player]",
			"Información de la memoria [meminfo]",
			"Montar [mount]",
			"Estado de la red [netstats]",
			"Administración de redes [network_management]",
			"Notificaciones [notification]",
			"Paquetes [package]",
			"Permisos [permission]",
			"Teléfono [phone]",
			"Energía [power]",
			"Reiniciar [reboot]",
			"Captura de pantalla [screenshot]",
			"Buscar [search]",
			"Sensor [sensor]",
			"Agenda SIM [simphonebook]",
			"Barra de estado [statusbar]",
			"Registro de llamadas [telephony.registry]",
			"Regulador [throttle]",
			"Estados de uso [usagestats]",
			"Vibrador [vibrator]",
			"Fondo de pantalla [wallpaper]",
			"WiFi [wifi]",
			"Ventana [window]"});

			this.viewInfoL.Text = "Ver información de:";
			this.refreshB.Text = "Refrescar";
			this.autorefreshCB.Text = "Auto refrescar cada";
			this.autorefreshL.Text = "milisegundos";
			this.Text = "Información del dispositivo";

		}
		
        string device;

        private void DeviceInfoF_Load(object sender, EventArgs e)
        {
            this.Text += " [" + device + "]";
        }

        private void availableInfoLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = availableInfoLB.SelectedIndex;
            if (i < 0)
                return;

            RefreshInfo();
        }

        void CheckAutorefresh()
        {
            int i = availableInfoLB.SelectedIndex;
            if (i < 0)
                refreshT.Enabled = false;
            else
                refreshT.Enabled = autorefreshCB.Checked;
        }

        private void refreshB_Click(object sender, EventArgs e) { RefreshInfo(); }

        private void refreshT_Tick(object sender, EventArgs e) { RefreshInfo(); }

        private void autorefreshCB_CheckedChanged(object sender, EventArgs e) { CheckAutorefresh(); }

        private void autorefreshNUD_ValueChanged(object sender, EventArgs e) { refreshT.Interval = (int)autorefreshNUD.Value; }

        void RefreshInfo()
        {
            string property = availableInfoLB.SelectedItem.ToString().Split('[')[1].Replace("]", "");

            string results = Adb.UseADBCommand("shell dumpsys " + property, device);

            informationTB.Text = results;
        }
    }
}
