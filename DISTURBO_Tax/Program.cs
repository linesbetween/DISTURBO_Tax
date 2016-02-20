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
