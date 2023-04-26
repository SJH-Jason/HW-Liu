using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int glasses = 0;
        int glasses1 = 0;
        int glasses2 = 0;
        int glasses3 = 0;
        int beer1 = 0;
        int Teq1 = 0;
        int Whisky1 = 0;
        int Wine1 = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            beer1 = beer1 + 120;
            glasses++;
            listBox1.Items.Add("啤酒");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teq1 = Teq1 + 180;
            glasses1++;
            listBox1.Items.Add("龍舌蘭");
            //listBox1.Text = ("龍舌蘭Tequila x" + glasses1 + ",共NT$" + Teq1 + "元");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Whisky1 = Whisky1 + 350;
            glasses2++;
            listBox1.Items.Add("威士忌");
            //listBox1.Text = ("威士忌Whisky x" + glasses2 + ",共NT$" + Whisky1 + "元");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wine1 = Wine1 + 320;
            glasses3++;
            listBox1.Items.Add("紅酒");
            //listBox1.Text = ("紅酒Wine x" + glasses3 + ",共NT$" + Wine1 + "元");
        }
    }
}
