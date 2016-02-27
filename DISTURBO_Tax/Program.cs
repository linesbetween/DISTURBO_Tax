// This program takes user input, 
// then calculates tax to be paid or refund
// Print a list of user record
// Program.cs
// CIT 287 Hanfei Xu
// Feb 20 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISTURBO_Tax
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
            //frmDataEntry dataEntry = new frmDataEntry();
            //ResultSet resultSet = new ResultSet();
            Application.Run(new frmWelcom());
        }
               

    }
}
