﻿/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public static class Program
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
                Application.Run(new MainForm());
            };
            
        }
    }
}
