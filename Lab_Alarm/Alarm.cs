using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Alarm
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labDateTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (labDateTime.Text == $"{hour}:{minutes}:{second}")
            {
                MessageBox.Show("時間到了");
            }

        }
        string hour = "";
        string minutes = "";
        string second = "";   
        private void btnSet_Click(object sender, EventArgs e)
        {
            hour = txthour.Text; //定義hour的變數
            minutes = txtminutes.Text;//定義miuntes的變數
            second = txtsecond.Text;//定義second的變數
            //12:12:12
            //12 : 12 :12 = 12:12:12
            //現在時間等於設定時間的時候 跳出時間到了的MessageBox
            
            
        }
    }
}
