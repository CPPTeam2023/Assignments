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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
                MessageBox.Show("Kindly Select the Option");

            else
            {
                if (radioButton3.Checked)
                {

                    MessageBox.Show("Correct Answer");

                    Form3 frm3 = new J5M.Form3();
                    frm3.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Try Again");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
