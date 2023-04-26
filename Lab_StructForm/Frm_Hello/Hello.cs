using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Hello
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }
       
        private void btnHello1_Click(object sender, EventArgs e)
        {
            string name1 = txtBox1.Text;
            string name2 = txtBox2.Text;
            string name3 = txtBox3.Text;
            string name4 = txtBox4.Text;
            MessageBox.Show("Hello! 我是" + name1 + "\n" +
                            "英文名字是" + name2 + "\n" +
                            "性別是 " + name3 + "\n" +
                            "星座是" + name4 + "\n" +
                            "很高興認識你!!!");
        }

        private void btnHello2_Click(object sender, EventArgs e)
        {
            string name1 = txtBox1.Text;
            string name2 = txtBox2.Text;
            string name3 = txtBox3.Text;
            string name4 = txtBox4.Text;
            MessageBox.Show("Hello! 我是" + name1 + "\n" +
                            "英文名字是" + name2 + "\n" +
                            "性別是 " + name3 + "\n" +
                            "星座是" + name4 + "\n" +
                            "很高興認識你!!!");
        }
    }
}
