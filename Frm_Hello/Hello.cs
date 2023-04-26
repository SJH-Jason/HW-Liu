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
        string name1;
        string name2;
        string sex;
        string starsign;
        private void btnHello1_Click(object sender, EventArgs e)
        {
             name1 = txtBox1.Text;
             name2 = txtBox2.Text;
             sex   = txtBox3.Text;
             starsign  = txtBox4.Text;
            MessageBox.Show("Hello! 我是" + name1 + "\n" +
                            "英文名字是" + name2 + "\n" +
                            "性別是 " + sex + "\n" +
                            "星座是" + starsign + "\n" +
                            "很高興認識你!!!");
        }

        private void btnHello2_Click(object sender, EventArgs e)
        {
            name1 = txtBox1.Text;
            name2 = txtBox2.Text;
            sex = txtBox3.Text;
            starsign = txtBox4.Text;
            MessageBox.Show("Hello! 我是" + name1 + "\n" +
                            "英文名字是" + name2 + "\n" +
                            "性別是 " + sex + "\n" +
                            "星座是" + starsign + "\n" +
                            "很高興認識你!!!");
        }
    }
}
