using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Frm_StudentGrade.Grade_unit;
    
    

namespace Frm_StudentGrade
{
    public partial class studentgrade : Form
    { 
       
        public studentgrade()
        {
            InitializeComponent();
        }
        //Grade_unit Mygrade = new Grade_unit();
       
        

        private void btnadd_Click(object sender, EventArgs e)
        {
            Grade_unit Mygrade = new Grade_unit();//建造一個成績的物件
            Name = txtname.Text;
            Mygrade.Chi = Convert.ToInt32(txtchi.Text);
            Mygrade.Eng = Convert.ToInt32(txteng.Text);
            Mygrade.Math = Convert.ToInt32(txtmath.Text);

            ListViewItem item = new ListViewItem(Name);//宣告一個新的ListViewItem() ()為第一欄的東西
            //item.SubItems.Add(Mygrade.Chi.ToString());//追加子項目(第二攔)
            
            item.SubItems.AddRange(new string[] { Mygrade.Chi.ToString(),Mygrade.Eng.ToString(),Mygrade.Math.ToString()
                                                 ,Mygrade.totalponit().ToString(),Mygrade.average().ToString()
                                                 ,Mygrade.minpoint(),Mygrade.maxpoint()});//純顯示出來
            listView.Items.Add(item);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Grade_unit Mygrade = new Grade_unit();
            Random rd = new Random();
            Name = (listView.Items.Count + 1).ToString();
            Mygrade.Chi = rd.Next(1, 100);
            Mygrade.Eng = rd.Next(1, 100);
            Mygrade.Math = rd.Next(1, 100);

            ListViewItem item = new ListViewItem(Name);
            item.SubItems.AddRange(new string[]{Mygrade.Chi.ToString(), Mygrade.Eng.ToString(), Mygrade.Math.ToString()
                                                 , Mygrade.totalponit().ToString(), Mygrade.average().ToString()
                                                 , Mygrade.minpoint(), Mygrade.maxpoint()});
            listView.Items.Add(item);
        }

        private void btnadds_Click(object sender, EventArgs e)
        {
            Random rd = new Random();//限定random 放到裡面的話會重置
           
            for (int i =0;i<=20;i++)
            {
                Grade_unit Mygrade = new Grade_unit();
                Name = (listView.Items.Count + 1).ToString();
                Mygrade.Chi = rd.Next(1, 100);
                Mygrade.Eng = rd.Next(1, 100);
                Mygrade.Math = rd.Next(1, 100);


                ListViewItem item = new ListViewItem(Name);
                item.SubItems.AddRange(new string[]{Mygrade.Chi.ToString(), Mygrade.Eng.ToString(), Mygrade.Math.ToString()
                                                 , Mygrade.totalponit().ToString(), Mygrade.average().ToString()
                                                 , Mygrade.minpoint(), Mygrade.maxpoint()});
                listView.Items.Add(item);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            listView1.Items.Clear();
        }
        

        private void btnstat_Click(object sender, EventArgs e)
        {
            int ChiSum = 0;
            int EngSum = 0;
            int MathSum = 0;
            double Chiave = 0;
            double Engave = 0;
            double Mathave = 0;
            int Count = listView.Items.Count;
            int Chimax = 0;
            int Chimin = 100;
            int Engmax = 0;
            int Engmin = 100;
            int Mathmax = 0;
            int Mathmin = 100;

            foreach (ListViewItem item in listView.Items)
            {

                int C = Convert.ToInt32(item.SubItems[1].Text);
                int E = Convert.ToInt32(item.SubItems[2].Text);
                int M = Convert.ToInt32(item.SubItems[3].Text);
            ChiSum += C;
            EngSum += E;
            MathSum += M;

            if (C > Chimax)
            {
                Chimax = C;
            }
            if (E > Engmax)
            {
                Engmax = E;
            }
            if (M > Mathmax)
            {
                Mathmax = M;
            };
            if (C < Chimin)
            {
                Chimin = C;
            }
            if (E < Engmin)
            {
                Engmin = E;
            }
            if (M < Mathmin)
            {
                Mathmin = M;
            }
        }
            Chiave = ChiSum / Count;
            Engave = EngSum / Count;
            Mathave = MathSum / Count;

            listView1.Items.Clear();
            ListViewItem I = new ListViewItem("總分");
          I.SubItems.AddRange(new string[] { ChiSum.ToString(), EngSum.ToString(), MathSum.ToString()});
            listView1.Items.Add(I);
            ListViewItem X = new ListViewItem("平均");
          X.SubItems.AddRange(new string[] { Chiave.ToString(), Engave.ToString(), Mathave.ToString()});
            listView1.Items.Add(X);
            ListViewItem Z = new ListViewItem("最高分");
          Z.SubItems.AddRange(new string[] { Chimax.ToString(), Engmax.ToString(), Mathmax.ToString() });
            listView1.Items.Add(Z);
            ListViewItem A = new ListViewItem("最低分");
          A.SubItems.AddRange(new string[] { Chimin.ToString(), Engmin.ToString(), Mathmin.ToString() });
            listView1.Items.Add(A);

            //int ChiSum = 0;
            //int EngSum = 0;
            //int MathSum = 0;
            //double Chiave = 0;
            //double Engave = 0;
            //double Mathave = 0;
            //int Count = listView.Items.Count;
            //int Chimax = 0;
            //int Chimin = 100;
            //int Engmax = 0;
            //int Engmin = 100;
            //int Mathmax = 0;
            //int Mathmin = 100;
            ///*for(int i= 0; i< listView.Count; i++
            // * {
            // *     listView[i]
            // * }
             
            // */
            //foreach (ListViewItem item in listView1.Items)
            //{
            //    //抓總分
            //    //國文
            //    int C = Convert.ToInt32(item.SubItems[1].Text);
            //    int E = Convert.ToInt32(item.SubItems[2].Text);
            //    int M = Convert.ToInt32(item.SubItems[3].Text);
            //    ChiSum += C;
            //    EngSum += E;
            //    MathSum += M;

            //    if (C > Chimax)
            //    {
            //        Chimax = C;
            //    }
            //    if (E > Engmax)
            //    {
            //        Engmax = E;
            //    }
            //    if (M > Mathmax)
            //    {
            //        Mathmax = M;
            //    };
            //    if (C < Chimin)
            //    {
            //        Chimin = C;
            //    }
            //    if (E < Engmin)
            //    {
            //        Engmin = E;
            //    }
            //    if (M < Mathmin)
            //    {
            //        Mathmin = M;
            //    }

            //}
            //    Chiave = ChiSum / Count;
            //    Engave = EngSum / Count;
            //    Mathave = MathSum / Count;


            //    listView1.Items.Clear();
            //    ListViewItem I = new ListViewItem("總分");
            //    I.SubItems.AddRange(new string[] { ChiSum.ToString(), EngSum.ToString(), MathSum.ToString() });
            //    listView1.Items.Add(I);
            //    ListViewItem X = new ListViewItem("平均");
            //    X.SubItems.AddRange(new string[] { Chiave.ToString(), Engave.ToString(), Mathave.ToString() });
            //    listView1.Items.Add(X);
            //    ListViewItem Z = new ListViewItem("最高分");
            //    Z.SubItems.AddRange(new string[] { Chimax.ToString(), Engmax.ToString(), Mathmax.ToString() });
            //    listView1.Items.Add(Z);
            //    ListViewItem A = new ListViewItem("最低分");
            //    A.SubItems.AddRange(new string[] { Chimin.ToString(), Engmin.ToString(), Mathmin.ToString() });
            //    listView1.Items.Add(A);
            

        }

    }
    }
