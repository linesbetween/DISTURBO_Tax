namespace DISTURBO_Tax
{
    partial class frmResult
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
            this.lblAdjGross = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxAdjGross = new System.Windows.Forms.TextBox();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtBoxWithheld = new System.Windows.Forms.TextBox();
            this.lblWithheld = new System.Windows.Forms.Label();
            this.txtBoxPenalty = new System.Windows.Forms.TextBox();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.txtBoxOwed = new System.Windows.Forms.TextBox();
            this.lblOwed = new System.Windows.Forms.Label();
            this.txtBoxRefund = new System.Windows.Forms.TextBox();
            this.lblRefund = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdjGross
            // 
            this.lblAdjGross.AutoSize = true;
            this.lblAdjGross.Location = new System.Drawing.Point(52, 34);
            this.lblAdjGross.Name = "lblAdjGross";
            this.lblAdjGross.Size = new System.Drawing.Size(78, 13);
            this.lblAdjGross.TabIndex = 0;
            this.lblAdjGross.Text = "Adjusted Gross";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(255, 272);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBoxAdjGross
            // 
            this.txtBoxAdjGross.Location = new System.Drawing.Point(214, 34);
            this.txtBoxAdjGross.Name = "txtBoxAdjGross";
            this.txtBoxAdjGross.ReadOnly = true;
            this.txtBoxAdjGross.Size = new System.Drawing.Size(116, 20);
            this.txtBoxAdjGross.TabIndex = 2;
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.Location = new System.Drawing.Point(214, 72);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.ReadOnly = true;
            this.txtBoxTax.Size = new System.Drawing.Size(116, 20);
            this.txtBoxTax.TabIndex = 4;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(52, 72);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(76, 13);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Amount of Tax";
            // 
            // txtBoxWithheld
            // 
            this.txtBoxWithheld.Location = new System.Drawing.Point(214, 107);
            this.txtBoxWithheld.Name = "txtBoxWithheld";
            this.txtBoxWithheld.ReadOnly = true;
            this.txtBoxWithheld.Size = new System.Drawing.Size(116, 20);
            this.txtBoxWithheld.TabIndex = 6;
            // 
            // lblWithheld
            // 
            this.lblWithheld.AutoSize = true;
            this.lblWithheld.Location = new System.Drawing.Point(52, 107);
            this.lblWithheld.Name = "lblWithheld";
            this.lblWithheld.Size = new System.Drawing.Size(121, 13);
            this.lblWithheld.TabIndex = 5;
            this.lblWithheld.Text = "Amount of Tax Withheld";
            // 
            // txtBoxPenalty
            // 
            this.txtBoxPenalty.Location = new System.Drawing.Point(214, 142);
            this.txtBoxPenalty.Name = "txtBoxPenalty";
            this.txtBoxPenalty.ReadOnly = true;
            this.txtBoxPenalty.Size = new System.Drawing.Size(116, 20);
            this.txtBoxPenalty.TabIndex = 8;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(52, 142);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(42, 13);
            this.lblPenalty.TabIndex = 7;
            this.lblPenalty.Text = "Penalty";
            // 
            // txtBoxOwed
            // 
            this.txtBoxOwed.Location = new System.Drawing.Point(214, 179);
            this.txtBoxOwed.Name = "txtBoxOwed";
            this.txtBoxOwed.ReadOnly = true;
            this.txtBoxOwed.Size = new System.Drawing.Size(116, 20);
            this.txtBoxOwed.TabIndex = 10;
            // 
            // lblOwed
            // 
            this.lblOwed.AutoSize = true;
            this.lblOwed.Location = new System.Drawing.Point(52, 179);
            this.lblOwed.Name = "lblOwed";
            this.lblOwed.Size = new System.Drawing.Size(115, 13);
            this.lblOwed.TabIndex = 9;
            this.lblOwed.Text = "Tax Owed to  Fed Gov";
            // 
            // txtBoxRefund
            // 
            this.txtBoxRefund.Location = new System.Drawing.Point(214, 218);
            this.txtBoxRefund.Name = "txtBoxRefund";
            this.txtBoxRefund.ReadOnly = true;
            this.txtBoxRefund.Size = new System.Drawing.Size(116, 20);
            this.txtBoxRefund.TabIndex = 12;
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.Location = new System.Drawing.Point(52, 218);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(124, 13);
            this.lblRefund.TabIndex = 11;
            this.lblRefund.Text = "Refund Due to Taxpayer";
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 324);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxRefund);
            this.Controls.Add(this.lblRefund);
            this.Controls.Add(this.txtBoxOwed);
            this.Controls.Add(this.lblOwed);
            this.Controls.Add(this.txtBoxPenalty);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.txtBoxWithheld);
            this.Controls.Add(this.lblWithheld);
            this.Controls.Add(this.txtBoxTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtBoxAdjGross);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAdjGross);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdjGross;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBoxAdjGross;
        private System.Windows.Forms.TextBox txtBoxTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtBoxWithheld;
        private System.Windows.Forms.Label lblWithheld;
        private System.Windows.Forms.TextBox txtBoxPenalty;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.TextBox txtBoxOwed;
        private System.Windows.Forms.Label lblOwed;
        private System.Windows.Forms.TextBox txtBoxRefund;
        private System.Windows.Forms.Label lblRefund;
    }
}