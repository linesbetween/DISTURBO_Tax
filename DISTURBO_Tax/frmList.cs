﻿using System;
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
    public partial class frmList : Form
    {
        public List<Record> list;

        public frmList()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            txtList.AppendText("SSN".PadRight(20) + "Name".PadRight(40) + "Owed".PadRight(35) + "Refund".PadRight(35) + "\n");
            for (int i = 0; i < list.Count; i++)
            {
                txtList.AppendText(list[i].toString());
            }
        }
         
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

       

       
    }
}
