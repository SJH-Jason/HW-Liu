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

        private void 另存新檔AToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtempty.Text, Encoding.Default);
            }
        }



        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtempty.Text, Encoding.Default);
                }
            }
            else
            { 
                File.WriteAllText(openFileDialog1.FileName, txtempty.Text, Encoding.Default);
                
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            txtempty.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            txtempty.Cut();
        }

        private void 自動換行toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            txtempty.WordWrap = !txtempty.WordWrap;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

               txtempty.ForeColor = Color.Red; //先定義txtempty的字體為紅色
               string M = txtempty.Text;//宣告變數
               txtempty.Text = M;
            
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("請給我作業100分! ! ! !");
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            txtempty.ForeColor = Color.Green; //先定義txtempty的字體為紅色
            string M = txtempty.Text;//宣告變數
            txtempty.Text = M;
        }

        private void toolStripComboBox3_Click(object sender, EventArgs e)
        {
            txtempty.ForeColor = Color.Blue; //先定義txtempty的字體為紅色
            string M = txtempty.Text;//宣告變數
            txtempty.Text = M;
        }

        private void toolStripComboBox4_Click(object sender, EventArgs e)
        {
            txtempty.ForeColor = Color.Black; //先定義txtempty的字體為紅色
            string M = txtempty.Text;//宣告變數
            txtempty.Text = M;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            txtempty.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtempty.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtempty.Text, Encoding.Default);
                }
                else
                {
                    File.WriteAllText(openFileDialog1.FileName, txtempty.Text, Encoding.Default);
                }

            }
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtempty.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("請給我作業100分! ! ! !");
        }
    }
}
