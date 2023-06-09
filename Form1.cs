using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J5M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((!radioButton3.Checked) && (!radioButton4.Checked))
                MessageBox.Show("Kindly Select the Option");
            else
            {
                if (radioButton3.Checked)
                {

                    MessageBox.Show("Correct Answer");

                    Form2 frm2 = new J5M.Form2();
                    frm2.Show();

                    this.Hide();
                }
                else
                    MessageBox.Show("Try Again");
            }
        }
    }
}
