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
    public partial class frmResult : Form
    {
        public ResultSet resultSet; 

        public frmResult()
        {
            InitializeComponent();
            
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            //this.Tag.getTax() - NOT WORKING
            txtBoxAdjGross.Text = String.Format("{0:c}",resultSet.getAdjGross());
            txtBoxTax.Text = String.Format("{0:c}",Convert.ToString(resultSet.getTax()));
            txtBoxWithheld.Text = String.Format("{0:c}", Convert.ToString(resultSet.getWithheld()));
            txtBoxPenalty.Text = String.Format("{0:c}",Convert.ToString(resultSet.getPenalty()));
            txtBoxOwed.Text = String.Format("{0:c}",Convert.ToString(resultSet.getOwed()));
            txtBoxRefund.Text = String.Format("{0:c}",Convert.ToString(resultSet.getRefund()));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
                        
            this.DialogResult = DialogResult.OK;
            //this.Visible = false;

        }

     

}



}
