using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class Form2 : Form
    {
        double salary;
        double businessSales;
        double investmentYields;
        String label;
        double otherIncome;


        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (checkBoxOthers.Checked)
            {
                textBoxOthersLbl.Enabled = true;
                textBoxOthersAmt.Enabled = true;
            }


            salary = (double.Parse(textBoxSalary.Text));
            businessSales = (double.Parse(textBoxBiz.Text));
            investmentYields = (double.Parse(textBoxInv.Text));
            label = textBoxOthersLbl.Text;
            otherIncome = (double.Parse(textBoxOthersAmt.Text));

            MessageBox.Show("Are you sure?");
            Form3 form = new Form3();
            form.Show();

        }
    }
}
