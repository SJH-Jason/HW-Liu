using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_PosPos
{
    public partial class Frm_Pos : Form
    {
        int BearCost = 120;
        int BearCups = 0;

        int TequilaCost = 180;
        int TequilaCups = 0;

        int WhiskyCost = 350;
        int WhiskyCups = 0;

        int WineCost = 320;
        int WineCups = 0;

        string ItemFormat = "{0} x {1},共NT$ {2}元";

        public Frm_Pos()
        {
            InitializeComponent();
        }
        private void CalTotalPrice()
        {
            int total = (BearCost * BearCups) + (TequilaCost * TequilaCups) +
                        (WhiskyCost * WhiskyCups) + (WineCost * WineCups);

            lblTotalPrice.Text = total.ToString();
        }
        private void UpdateListBox(string itemname, string cups, string total)
        {
            if (listBox1.Items[0].ToString() == "尚未點餐")
            {
                listBox1.Items.Clear();
            }

            int ItemIndex = -1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().IndexOf(itemname) != -1)//看不懂
                {
                    ItemIndex = i;
                    break;
                }
            }
            string Item = string.Format(ItemFormat, itemname, cups, total);

            if (ItemIndex != -1)
            {
                listBox1.Items[ItemIndex] = Item;
            }
            else
            {
                listBox1.Items.Add(Item);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            BearCups++;
            UpdateListBox("啤酒", BearCups.ToString(), (BearCost * BearCups).ToString());
            CalTotalPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TequilaCups++;
            UpdateListBox("龍舌蘭", TequilaCups.ToString(), (TequilaCost * TequilaCups).ToString());
            CalTotalPrice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WhiskyCups++;
            UpdateListBox("威士忌", WhiskyCups.ToString(), (WhiskyCost * WhiskyCups).ToString());
            CalTotalPrice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WineCups++;
            UpdateListBox("紅酒", WineCups.ToString(), (WineCost * WineCups).ToString());
            CalTotalPrice();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("尚未點餐");
            lblTotalPrice.Text = "0";
            BearCups = 0;
            TequilaCups = 0;
            WhiskyCups = 0;
            WineCups = 0;
        }

        private void cash_Click(object sender, EventArgs e)
        {
            if ((BearCost * BearCups) + (TequilaCost * TequilaCups) + (WhiskyCost * WhiskyCups) + (WineCost * WineCups) == 0)

            {

                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int total = (BearCost * BearCups) + (TequilaCost * TequilaCups) +
                           (WhiskyCost * WhiskyCups) + (WineCost * WineCups);
                MessageBox.Show("總金額 : NT$" + total.ToString());
            }
        }

        private void creditcard_Click(object sender, EventArgs e)
        {
            if ((BearCost * BearCups) + (TequilaCost * TequilaCups) + (WhiskyCost * WhiskyCups) + (WineCost * WineCups) == 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int total = (BearCost * BearCups) + (TequilaCost * TequilaCups) +
                        (WhiskyCost * WhiskyCups) + (WineCost * WineCups);
                MessageBox.Show("總金額 : NT$" + total.ToString() + "\n" +
                                "折扣後總金額 : NT$" + (total * 0.9).ToString());
            }
        }
    }
    }
