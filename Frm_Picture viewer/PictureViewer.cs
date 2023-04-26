using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Picture_viewer
{
    public partial class Picvi : Form
    {
        public Picvi()
        {
            InitializeComponent();
        }

       
        private void PictureViewer_Load(object sender, EventArgs e)
        {
            int x = 20; //設定pictureBox1的起點
            int y = 20;
            string dir = @"../../../Frm_Picture viewer/Resources"; //設定圖片的資料夾來源
            string[] images = Directory.GetFiles(dir); //創建新的字串陣列並從dir抓去圖片檔案的路徑
            foreach (string pictures in images)//使用迴圈抓取每一張圖片的路徑
            {
                PictureBox pic = new PictureBox(); //建立新的名字叫做pic的實體

                pic.Size = new Size(100, 100); //設定pic圖片的尺寸

                pic.Location = new Point(x, y); //設定pic圖片的座標

                pic.Image = Image.FromFile(pictures);//用Image.FromFile的方法使用圖片的路徑抓取圖片
               
                pic.SizeMode = PictureBoxSizeMode.StretchImage;//1.圖片要顯示整張圖片 
              
                x += pic.Width+ 100; //2.設定picture box的間距 ->  x每次都要往右

                //3.如果到了最邊界的時候，那就要換行 -> x > width ; x = 最初點 y要往下
                if (x > this.Width-100)
                {
                    x = 20; y += 100;
                }
                pic.Click += new EventHandler(pic_Click);//使pic_Click重複使用
                panel1.Controls.Add(pic);
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            // 將sender轉型成PictureBox

            PictureBox pic = sender as PictureBox;

            picform piform = new picform();
            piform.pic = pic;
            piform.Show();

        }

        private void Picvi_Resize(object sender, EventArgs e) //圖片超過form邊界時會自動換行
        {
            panel1.Controls.Clear();
            int x = 20;
            int y = 20;
            string dir = @"../../../Frm_Picture viewer/Resources";
            string[] images = Directory.GetFiles(dir);

            foreach (string pictures in images)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 100);
                pic.Location = new Point(x, y);
                pic.Image = Image.FromFile(pictures);
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                x += pic.Width+ 100;
                if (x > this.Width-100)
                {
                    x = 20; y += 100;
                }
                panel1.Controls.Add(pic);
                pic.Click += new EventHandler(pic_Click);

            }

        }

    }
}


