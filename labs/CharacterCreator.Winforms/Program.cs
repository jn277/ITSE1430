﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    static class Program
    {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    //[STAThread]
        static void Main( string[] args)
        {
            while (true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new MainForm());
            };
        }
    }
}
