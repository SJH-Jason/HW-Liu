using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Clac
{
    public partial class Clac : Form
    {
        public Clac()
        {
            InitializeComponent();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }

            else if (txtnum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                Double num1 = Convert.ToDouble(txtnum1.Text);
                Double num2 = Convert.ToDouble(txtnum2.Text);
                labanswer.Text = (num1 + num2).ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }

            else if (txtnum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                Double num1 = Convert.ToDouble(txtnum1.Text);
                Double num2 = Convert.ToDouble(txtnum2.Text);
                labanswer.Text = (num1 - num2).ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }

            else if (txtnum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                Double num1 = Convert.ToDouble(txtnum1.Text);
                Double num2 = Convert.ToDouble(txtnum2.Text);
                labanswer.Text = (num1 * num2).ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }

            else if (txtnum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                Double num1 = Convert.ToDouble(txtnum1.Text);
                Double num2 = Convert.ToDouble(txtnum2.Text);
                labanswer.Text = (num1 / num2).ToString();
            }
        }
    }
}
