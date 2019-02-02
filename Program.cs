using System;
using System.Windows.Forms;

namespace Woodpecker
{
    static class Program
    {
        public static bool DISABLE_ENCRYPTION = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
