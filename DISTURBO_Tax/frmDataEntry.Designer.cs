namespace DISTURBO_Tax
{
    partial class frmDataEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtExempt = new System.Windows.Forms.TextBox();
            this.lblExempt = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.lblMed = new System.Windows.Forms.Label();
            this.txtExcise = new System.Windows.Forms.TextBox();
            this.lblExcise = new System.Windows.Forms.Label();
            this.txtEstate = new System.Windows.Forms.TextBox();
            this.lblEstate = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lblCaptial = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWithheld = new System.Windows.Forms.TextBox();
            this.lblWithheld = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtEarn = new System.Windows.Forms.TextBox();
            this.lblEarning = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.MaskedTextBox();
            this.txtSSN = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(529, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(55, 83);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(49, 13);
            this.lblAddr.TabIndex = 3;
            this.lblAddr.Text = "Address*";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(128, 81);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(126, 20);
            this.txtAddr.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(128, 117);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(126, 20);
            this.txtCity.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(55, 120);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City*";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(55, 221);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(33, 13);
            this.lblSSN.TabIndex = 11;
            this.lblSSN.Text = "SSN*";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(55, 189);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(54, 13);
            this.lblZip.TabIndex = 9;
            this.lblZip.Text = "Zip Code*";
            // 
            // txtExempt
            // 
            this.txtExempt.Location = new System.Drawing.Point(128, 256);
            this.txtExempt.Name = "txtExempt";
            this.txtExempt.Size = new System.Drawing.Size(126, 20);
            this.txtExempt.TabIndex = 14;
            // 
            // lblExempt
            // 
            this.lblExempt.AutoSize = true;
            this.lblExempt.Location = new System.Drawing.Point(55, 258);
            this.lblExempt.Name = "lblExempt";
            this.lblExempt.Size = new System.Drawing.Size(65, 13);
            this.lblExempt.TabIndex = 13;
            this.lblExempt.Text = "Exemptions*";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(349, 294);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(440, 294);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 16;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtMed
            // 
            this.txtMed.Location = new System.Drawing.Point(440, 256);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(126, 20);
            this.txtMed.TabIndex = 30;
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(316, 258);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(88, 13);
            this.lblMed.TabIndex = 29;
            this.lblMed.Text = "Medical Expense";
            // 
            // txtExcise
            // 
            this.txtExcise.Location = new System.Drawing.Point(440, 219);
            this.txtExcise.Name = "txtExcise";
            this.txtExcise.Size = new System.Drawing.Size(126, 20);
            this.txtExcise.TabIndex = 28;
            // 
            // lblExcise
            // 
            this.lblExcise.AutoSize = true;
            this.lblExcise.Location = new System.Drawing.Point(316, 221);
            this.lblExcise.Name = "lblExcise";
            this.lblExcise.Size = new System.Drawing.Size(59, 13);
            this.lblExcise.TabIndex = 27;
            this.lblExcise.Text = "Excise Tax";
            // 
            // txtEstate
            // 
            this.txtEstate.Location = new System.Drawing.Point(440, 186);
            this.txtEstate.Name = "txtEstate";
            this.txtEstate.Size = new System.Drawing.Size(126, 20);
            this.txtEstate.TabIndex = 26;
            // 
            // lblEstate
            // 
            this.lblEstate.AutoSize = true;
            this.lblEstate.Location = new System.Drawing.Point(316, 189);
            this.lblEstate.Name = "lblEstate";
            this.lblEstate.Size = new System.Drawing.Size(83, 13);
            this.lblEstate.TabIndex = 25;
            this.lblEstate.Text = "Real Estate Tax";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(440, 150);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(126, 20);
            this.txtCapital.TabIndex = 24;
            // 
            // lblCaptial
            // 
            this.lblCaptial.AutoSize = true;
            this.lblCaptial.Location = new System.Drawing.Point(316, 152);
            this.lblCaptial.Name = "lblCaptial";
            this.lblCaptial.Size = new System.Drawing.Size(91, 13);
            this.lblCaptial.TabIndex = 23;
            this.lblCaptial.Text = "Captial Gain/Loss";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Not on W-2";
            // 
            // txtWithheld
            // 
            this.txtWithheld.Location = new System.Drawing.Point(440, 81);
            this.txtWithheld.Name = "txtWithheld";
            this.txtWithheld.Size = new System.Drawing.Size(126, 20);
            this.txtWithheld.TabIndex = 20;
            // 
            // lblWithheld
            // 
            this.lblWithheld.AutoSize = true;
            this.lblWithheld.Location = new System.Drawing.Point(316, 83);
            this.lblWithheld.Name = "lblWithheld";
            this.lblWithheld.Size = new System.Drawing.Size(120, 13);
            this.lblWithheld.TabIndex = 19;
            this.lblWithheld.Text = "Tax Withheld (Positive)*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(316, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "From W-2";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(55, 152);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(36, 13);
            this.lblState.TabIndex = 31;
            this.lblState.Text = "State*";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(128, 150);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 32;
            // 
            // txtEarn
            // 
            this.txtEarn.Location = new System.Drawing.Point(440, 42);
            this.txtEarn.Name = "txtEarn";
            this.txtEarn.Size = new System.Drawing.Size(126, 20);
            this.txtEarn.TabIndex = 34;
            // 
            // lblEarning
            // 
            this.lblEarning.AutoSize = true;
            this.lblEarning.Location = new System.Drawing.Point(316, 45);
            this.lblEarning.Name = "lblEarning";
            this.lblEarning.Size = new System.Drawing.Size(123, 13);
            this.lblEarning.TabIndex = 33;
            this.lblEarning.Text = "Gross Earning (Positive)*";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(58, 20);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(87, 13);
            this.lblPerson.TabIndex = 35;
            this.lblPerson.Text = "Personal Data";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(128, 189);
            this.txtZip.Mask = "00000";
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(37, 20);
            this.txtZip.TabIndex = 49;
            this.txtZip.ValidatingType = typeof(int);
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(128, 223);
            this.txtSSN.Mask = "000-00-0000";
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(68, 20);
            this.txtSSN.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fields with * are required";
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 340);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.txtEarn);
            this.Controls.Add(this.lblEarning);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.txtExcise);
            this.Controls.Add(this.lblExcise);
            this.Controls.Add(this.txtEstate);
            this.Controls.Add(this.lblEstate);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.lblCaptial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWithheld);
            this.Controls.Add(this.lblWithheld);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtExempt);
            this.Controls.Add(this.lblExempt);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Name = "frmDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISTURBO TAX";
            this.Load += new System.EventHandler(this.frmDataEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtExempt;
        private System.Windows.Forms.Label lblExempt;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.TextBox txtExcise;
        private System.Windows.Forms.Label lblExcise;
        private System.Windows.Forms.TextBox txtEstate;
        private System.Windows.Forms.Label lblEstate;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label lblCaptial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWithheld;
        private System.Windows.Forms.Label lblWithheld;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtEarn;
        private System.Windows.Forms.Label lblEarning;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.MaskedTextBox txtZip;
        private System.Windows.Forms.MaskedTextBox txtSSN;
        private System.Windows.Forms.Label label1;
    }
}