
using HMController;
using System;
using System.Windows.Forms;

namespace P3E00
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ahorcado(new AhorcadoController()));
        }
    }
}
