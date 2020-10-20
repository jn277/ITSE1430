/*
 * ITSE 1430 
 * Movie Library Console Application
 */
using System;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace MovieLibrary.WinformsHost
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            //System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new MovieLibrary.WinformsHost.MainForm());
        }
    }
}
