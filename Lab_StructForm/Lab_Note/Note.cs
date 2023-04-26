using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Note
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void 檔案FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtempty.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

       private void 另存新檔AToolStripMenuItem_Click(object sender,EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,txtempty.Text,Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.FileName =="")
            {
                if(saveFileDialog1.ShowDialog() ==DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName,txtempty.Text, Encoding.Default);
                }
                else
                {
                    File.WriteAllText(openFileDialog1.FileName, txtempty.Text, Encoding.Default);
                }
                   
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            txtempty.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtempty.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtempty.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtempty.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtempty.SelectAll();
        }

        private void 搜尋取代_Click(object sender, EventArgs e)
        {
            {
                panel1.Visible = true;
            }
        }
       
        private void btnshotdown_Click_1(object sender, EventArgs e)
        {
            {
                panel1.Visible = false;
            }
        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            int P;
            if (textBox1.SelectionLength > 0)
            {
                P = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart + 1);
            }
            else
            {
                P = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart);
            }
            
            if (P < 0)
            {
                MessageBox.Show("未發現搜尋字串!!!");
            }
            else
            {
                textBox1.SelectionStart = P;
                textBox1.SelectionLength = textBox2.SelectionLength;
                textBox1.Select();

            }
        }

        private void btbreplace_Click(object sender, EventArgs e)
        {

        }

        private void 顏色toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtempty.ForeColor = colorDialog1.Color;
        }

        private void 字型toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtempty.Font = fontDialog1.Font;
        }

        private void 大寫toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //txtempty.Text =  txtempty.Text.ToUpper();
            string N = txtempty.Text;
            txtempty.Text = N.ToUpper();
        }

        private void 小寫toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //txtempty.Text = txtempty.Text.ToLower();
            string M = txtempty.Text;
            txtempty.Text = M.ToLower();
            
        }

    }
}
