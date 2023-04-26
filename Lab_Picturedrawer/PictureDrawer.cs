using Lab_Picturedrawer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab_Picturedrawer
{
    public partial class PictureDrawer : Form
    {
        public PictureDrawer()
        {
            InitializeComponent();
        }
        
        private void PictureDrawer_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            //建置一個 800 x 600 點的點陣圖物件作為 pictureBox1 的 Image
            Graphics p = Graphics.FromImage(pictureBox1.Image);
            //宣告一個稱為 g 的繪圖物件，此物件來自於pictureBox1.Image
            p.Clear(Color.White);
            //使用 g 將 Image 清除為白底的狀況。

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        int x0, y0;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(colorDialog1.Color, trackBar1.Value);
                g.DrawLine(p ,x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                pictureBox1.Refresh ();
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label.Text = trackBar1.Value.ToString(); 
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 =  e.X ;
            y0 =  e.Y;
        }



    }
}
