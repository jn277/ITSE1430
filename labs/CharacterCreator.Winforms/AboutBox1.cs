/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MovieLibrary.WinformsHost
{
    partial class AboutBox1 : Form
    {
        public AboutBox1 ()
        {
            InitializeComponent();
            //this.Text = String.Format("About {0}", AssemblyTitle);
            this.Text = "About";
            //this.labelProductName.Text = AssemblyProduct;
            this.labelProductName.Text = "ITSE 1430";
            //this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelVersion.Text = "Fall 2020";
            //this.labelCompanyName.Text = AssemblyCompany;
            this.labelCompanyName.Text = "Donald Helaire";
        }
    }
}

