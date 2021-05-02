using System;
using System.Windows.Forms;

namespace Bankomat
{
    internal static class Program
    {
        public static string globalCardId = "12345678901";

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}