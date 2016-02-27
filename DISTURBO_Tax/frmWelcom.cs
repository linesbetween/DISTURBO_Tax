
// This program takes user input, 
// then calculates tax to be paid or refund
// Print a list of user record
// frmWelcome.cs
// CIT 287 Hanfei Xu
// Feb 20 2016


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISTURBO_Tax
{
    public partial class frmWelcom : Form
    {
        public frmWelcom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttEnter_Click(object sender, EventArgs e)
        {
            frmDataEntry dataEntry = new frmDataEntry();
            dataEntry.Visible = true;
            this.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit?";
            DialogResult button =
                    MessageBox.Show(message, "Welcome",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
