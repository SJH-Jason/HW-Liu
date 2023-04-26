using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Guess
{
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }
        Random answer = new Random();
        int result;
        int min = 1;
        int max = 100;
        private void btnguess_Click(object sender, EventArgs e)
        {
            panelshow.Visible = true;
            result = answer.Next(1, 100);
        }
        private void btnenter_Click(object sender, EventArgs e)
        {

            int inputnum = Convert.ToInt32(txtnum.Text);
            //按下去大於答案的話 秀出 too large 並給予提示 ~between~
            if (inputnum > min && inputnum < max)
            {
                if (inputnum < result)
                {
                    min = inputnum;
                    resultshow.Text = "too small" + "\n" +
                    "between" + " " + min + " " + "and" + max;
                }
                else if (inputnum > result)
                {
                    max = inputnum;
                    resultshow.Text = "too large" + "\n" +
                        "between" + min + "and" + max;
                }
                else if (inputnum == result)
                {
                    MessageBox.Show("恭喜答對了!!");
                }
            }
            else
            {
                MessageBox.Show("請輸入提示中" + min + "到" + max + "中的數字!!");
            }
        }
      
        
        private void Guess_Load(object sender, EventArgs e)
        {
            Random answer = new Random();
           
            result = answer.Next(1, 100);

        }
        private void btnanswer_Click(object sender, EventArgs e)
            {
                  
                   MessageBox.Show("Answer:" + result);
            }

            private void btncancel_Click(object sender, EventArgs e)
            {
                panelshow.Visible = false;
            }
        }
    } 

