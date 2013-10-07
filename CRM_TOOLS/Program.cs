using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CRM_TOOLS.Pantallas;

namespace CRM_TOOLS
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
            Application.Run(new RadForm1());
        }
    }
}
