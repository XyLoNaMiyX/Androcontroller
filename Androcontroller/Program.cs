using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Androcontroller
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainF());
        }
    }
}
