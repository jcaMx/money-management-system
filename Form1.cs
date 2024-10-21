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
    public partial class Form1 : Form
    {
        public static Form1 instance;

        String userType;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

            radioButton1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if either radio button is checked
            if (radioButton1.Checked)
            {
                userType = radioButton1.Text;
                button1.Enabled = true;
            }
            else if (radioButton2.Checked)
            {
                userType = radioButton2.Text;
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
