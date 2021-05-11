using System;
using System.Windows.Forms;

namespace Bankomat
{
    internal static class Program
    {
        public static string globalCardId = "";
        public static bool theme = true;

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}