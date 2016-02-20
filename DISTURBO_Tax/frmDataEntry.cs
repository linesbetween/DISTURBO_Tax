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
    public partial class frmDataEntry : Form
    {
        
        String[] state = new string[50] {"AL", "AK", "AR", "AZ", "CA", "CO", "CT", "DE", "FL", "GA",
                                         "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", 
                                         "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", 
                                         "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                                         "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"};       

        ResultSet resultSet = new ResultSet(0, 0, 0, 0, 0, 0);

        List<Record> list = new List<Record>();

        public frmDataEntry()
        {
            InitializeComponent();
        }

        private void frmDataEntry_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                cmbState.Items.Add(state[i]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit confirm
            string message = "Do you want to exit?";
            DialogResult button =
                    MessageBox.Show(message, "DataEntry",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }

                       
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {   
            //validate entry
            //TODO

            //get values from text box
            string name = txtName.Text;
            int ssn = Convert.ToInt32(txtSSN.Text);

            int exempt = Convert.ToInt32(txtExempt.Text);
            float earn = (float)Convert.ToDouble(txtEarn.Text);
            float withheld = (float)Convert.ToDouble(txtWithheld.Text);
            float capital = (float)Convert.ToDouble(txtCapital.Text);
            float estate = (float)Convert.ToDouble(txtEstate.Text);
            float excise = (float)Convert.ToDouble(txtExcise.Text);
            float med = (float)Convert.ToDouble(txtMed.Text);

            //calculate and assign values to resultset 
            resultSet = calculate(exempt, earn, withheld, capital, estate, excise, med);

            /* display result in this form*/
            txtBoxAdjGross.Text = Convert.ToString (resultSet.getAdjGross());
            txtBoxTax.Text = Convert.ToString(resultSet.getTax());
            txtBoxWithheld.Text = Convert.ToString(resultSet.getWithheld());
            txtBoxPenalty.Text = Convert.ToString(resultSet.getPenalty());
            txtBoxOwed.Text = Convert.ToString(resultSet.getOwed());
            txtBoxRefund.Text = Convert.ToString(resultSet.getRefund());

            //send result to formResult to display
            frmResult formResult = new frmResult();

            passResultSet(formResult, resultSet);


            //NOT WORKING- formResult.Tag = resultSet;            
            DialogResult selectedButton = formResult.ShowDialog();
            if (selectedButton == DialogResult.OK) {
                

                // store result into record list
                Record record = new Record(ssn, name, resultSet.getOwed(), resultSet.getRefund());
                list.Add(record);

                // clear data entry
                //TODO
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {   
            //sort list
            List<Record> sortedList = sortSSN(list);

            frmList formList = new frmList();

            //pass list to formList
            passList(formList, sortedList);

            /*display list in this form*/
            for (int i = 0; i < sortedList.Count;i++ )
            {
                txtList.AppendText(sortedList[i].toString());
            }

            
            formList.ShowDialog();
        }

        /*
        public bool IsValidData()
        {
            return
                // Validate the Monthly Investment text box
                IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
                IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

                // Validate the Yearly Interest Rate text box
                IsPresent(txtInterestRate, "Yearly Interest Rate") &&
                IsDecimal(txtInterestRate, "Yearly Interest Rate") &&
                IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 20) &&

                // Validate the Number of Years text box
                IsPresent(txtYears, "Number of Years") &&
                IsInt32(txtYears, "Number of Years") &&
                IsWithinRange(txtYears, "Number of Years", 1, 40);
        }
        */
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min
                    + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private ResultSet calculate(int exempt, float earn, float withheld, float capital, float estate, 
                                    float excise, float med)
        {   
            int adjGross, penalty, owed, refund; 
            float tax, withheldW2 ;

            withheldW2 = withheld; //???
            adjGross = round ((float) (earn - exempt*1000 - estate*0.25 - excise*0.25 - med*0.08 + capital*0.15));

            if (adjGross > 0 && adjGross <=999.99 )
            {
                tax = (float)(adjGross * 0.1); 
            }
            else if (adjGross >= 1000 && adjGross <= 9999.99)
            {
                tax = (float)((adjGross - 999.99) * 0.15 + 99.999);
            }
            else if (adjGross >= 10000 && adjGross <= 19999.99)
            {
                tax = (float)((adjGross - 9999.99) * 0.20 + 99.999 + 1499.9985);
            }
            else if (adjGross >= 20000 && adjGross <= 29999.99)
            {
                tax = (float)((adjGross - 19999.99) * 0.25 + 99.999 + 1499.9985 + 39999.998);
            }
            else 
            {
                tax = (float)((adjGross - 29999.99) * 0.28 + 99.999 + 1499.9985 + 3999.998 + 7499.9975);
            }

            if (tax <= withheldW2)
            {
                refund = round(withheldW2 - tax);
                owed = 0;
                penalty = 0;
            }
            else if (withheldW2 >= tax * 0.9)
            {
                refund = 0;
                owed = round (tax - withheldW2);
                penalty = 0;
            }
            else
            {
                refund = 0;
                penalty = round((float)((tax - withheldW2) * 0.1));
                owed = round(tax - withheldW2 + penalty);
            }
            


            ResultSet resultSet = new ResultSet(adjGross, tax, withheldW2, penalty, owed, refund);

            return resultSet;
        }

        private int round(float f)
        {
            int i;

            if (f - (int)f < 0.5)
                i = (int)f;
            else
                i = (int)f + 1;

            return i;
        }

        private List<Record> sortSSN(List<Record> list)
        {
            List<Record> sorted = list;
            sorted = list.OrderBy(o => o.getSSN()).ToList();
            return sorted;
        }

        private void passResultSet (frmResult formResult, ResultSet result){
            formResult.resultSet = result;
        }

        private void passList(frmList formList, List<Record> list)
        {
            formList.list = list;
        }
            
    }


    public class Record
    {
        int ssn;
        string name;
        int owed;
        int refund;

        public Record(int ssn, string name, int owed, int refund)
        {
            this.ssn = ssn;
            this.name = name;
            this.owed = owed;
            this.refund = refund;
        }

        public int getSSN() { return ssn; }

        public string toString()
        {
            return ssn + "    " + name + "    " + owed + "    " + refund + "\n";
        }
    }

    public class ResultSet
    {

        int adjGross;
        float tax;
        float withheld;
        int penalty;
        int owed;
        int refund;

        public ResultSet(int adjGross, float tax, float withheld, int penalty, int owed, int refund)
        {
            this.adjGross = adjGross;
            this.tax = tax;
            this.withheld = withheld;
            this.penalty = penalty;
            this.owed = owed;
            this.refund = refund;
        }

        public int getAdjGross() { return adjGross; }

        public float getTax() { return tax; }

        public float getWithheld() { return withheld; }    

        public int getOwed() { return owed; }

        public int getRefund() { return refund; }

        public int getPenalty() { return penalty; }

        public void setAdjGross(int set) { adjGross = set; }
        
        public void setTax(float set) { tax = set; }

        public void setWithheld(float set) { withheld = set; }

        public void setPenlty(int set) { penalty = set; }

        public void setOwed(int set) { owed = set; }

        public void setRefund(int set) { refund = set; }

    }

   
}
