using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_XOGAME
{
    public partial class XOGame : Form
    {
        public XOGame()
        {
            InitializeComponent();
        }
        int tmp = 0;
        
        public void judge()
        {
            
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == "X")
            {
                MessageBox.Show("X手方勝利"); reset();
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == "O")
            {
                MessageBox.Show("O手方勝利"); reset();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text == "X")
            {
                MessageBox.Show("X手方勝利"); reset();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text == "O")
            {
                MessageBox.Show("O手方勝利"); reset();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == "X")
            {
                MessageBox.Show("X手方勝利");
                reset();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == "O")
            {
                MessageBox.Show("O手方勝利");
                reset();//橫的六種狀況(包含O,X)
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == "X")
            {
                MessageBox.Show("X手方勝利");
                reset();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == "O")
            {
                MessageBox.Show("O手方勝利");
                reset();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text == "X")
            {
                MessageBox.Show("X手方勝利");
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text == "O")
            {
                MessageBox.Show("O手方勝利");
                reset();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text == "X")
            {
                MessageBox.Show("X手方勝利");
                reset();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text == "O")
            {
                MessageBox.Show("O手方勝利");
                reset();//直的六種狀況(包含O,X)
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == "X")
            {
                MessageBox.Show("X手方勝利");
                reset();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == "O")
            {
                MessageBox.Show("O手方勝利");
                reset();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == "X")
            {
                MessageBox.Show("X手方勝利");
                reset();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == "O")
            {
                MessageBox.Show("O手方勝利");//斜的四種狀況(包含O,X) 
                reset();
            }
            if(tmp==9)
            {
                MessageBox.Show("完局" + "平手!!按下開始重新對戰!!" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                reset();
            }
            
        }
         public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            tmp = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r= tmp % 2;

            if(r==0)
            {
                button1.Text = "O";
            }
            else
            {
                button1.Text = "X";
            }
            button1.Enabled = false;
            judge();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r = tmp % 2;

            if (r == 0)
            {
                button2.Text = "O";
            }
            else
            {
                button2.Text = "X";
            }
            button2.Enabled = false;
            judge();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r = tmp % 2;

            if (r == 0)
            {
                button3.Text = "O";
            }
            else
            {
                button3.Text = "X";
            }
            button3.Enabled = false;
            judge();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r = tmp % 2;

            if (r == 0)
            {
                button4.Text = "O";
            }
            else
            {
                button4.Text = "X";
            }
            button4.Enabled = false;
            judge();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r = tmp % 2;

            if (r == 0)
            {
                button5.Text = "O";
            }
            else
            {
                button5.Text = "X";
            }
            button5.Enabled = false;
            judge();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r = tmp % 2;

            if (r == 0)
            {
                button6.Text = "O";
            }
            else
            {
                button6.Text = "X";
            }
            button6.Enabled = false;
            judge();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r = tmp % 2;

            if (r == 0)
            {
                button7.Text = "O";
            }
            else
            {
                button7.Text = "X";
            }
            button7.Enabled = false;
            judge();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r = tmp % 2;

            if (r == 0)
            {
                button8.Text = "O";
            }
            else
            {
                button8.Text = "X";
            }
            button8.Enabled = false;
            judge();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int r;
            tmp += 1;
            r = tmp % 2;

            if (r == 0)
            {
                button9.Text = "O";
            }
            else
            {
                button9.Text = "X";
            }
            button9.Enabled = false;
            judge();
        }

        private void XOGame_Load(object sender, EventArgs e)
        {
            
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
    }




    

