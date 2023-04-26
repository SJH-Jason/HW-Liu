using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_screen
{
    public partial class screen : Form
    {
        public screen()
        {
            InitializeComponent();
        }

        private void Lab_screen_Load(object sender, EventArgs e)
        {
            pictureBox1.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        // Random t = new Random();
        int stepX = -5, stepY = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((pictureBox1.Location.X + pictureBox1.Width) > this.ClientSize.Width || pictureBox1.Location.X < 0)
                stepX = 0 - stepX;
            if ((pictureBox1.Location.Y + pictureBox1.Height) > this.ClientSize.Height || pictureBox1.Location.Y < 0)
                stepY = 0 - stepY;
            pictureBox1.Location = new Point(pictureBox1.Location.X + stepX, pictureBox1.Location.Y + stepY);




            ////label1.Text = DateTime.Now.ToString();
            ////label1.Left -= 5;
            //if (label1.Right < 0)
            //{
            //    label1.Left = this.ClientSize.Width;
            //    label1.Top = t.Next(this.Height - label1.Height);
            //}
        }

        private void screen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

//    if (stepX == 0 &;&; stepY == 0 )
//{
//          stepX = e.X ;
//          stepY = e.Y ;
//          return ;
//}
////判斷自螢幕保護程式執行後,滑鼠的位置是否變動
//else if (e.X != ixStart || e.Y != iyStart)
//{
//    Cursor.Show();
//    timerSaver.Enabled = false;
//    Application.Exit();
//};


//}
