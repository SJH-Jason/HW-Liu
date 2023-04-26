using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_studentgrade_list
{
    public partial class gradelist : Form
    {
        public gradelist()
        {
            InitializeComponent();
        }


        //全域成績集合
        List<Class_grade> Global_GradeList = new List<Class_grade>();

        private void btnadd_Click(object sender, EventArgs e)
        {
            Class_grade Mygrade = new Class_grade();

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

            //新增至全域集合
            Global_GradeList.Add(Mygrade);
        }



        private void btnclear_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            //清除全域集合
            Global_GradeList.Clear();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            Class_grade Mygrade = new Class_grade();

            Name = txtname.Text;
            Mygrade.Chi = Convert.ToInt32(txtchi.Text);
            Mygrade.Eng = Convert.ToInt32(txteng.Text);
            Mygrade.Math = Convert.ToInt32(txtmath.Text);


            ListViewItem item = new ListViewItem(Name);

            item.SubItems.AddRange(new string[] { Mygrade.Chi.ToString(),Mygrade.Eng.ToString(),Mygrade.Math.ToString()
                                                 ,Mygrade.totalponit().ToString(),Mygrade.average().ToString()
                                                 ,Mygrade.minpoint(),Mygrade.maxpoint()});


            listView.Items.Insert(0, item);

            //新增至全域集合
            Global_GradeList.Insert(0, Mygrade);
        }

       

        private void btb1_Click(object sender, EventArgs e)
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
            I.SubItems.AddRange(new string[] { ChiSum.ToString(), EngSum.ToString(), MathSum.ToString() });
            listView1.Items.Add(I);
            ListViewItem X = new ListViewItem("平均");
            X.SubItems.AddRange(new string[] { Chiave.ToString(), Engave.ToString(), Mathave.ToString() });
            listView1.Items.Add(X);
            ListViewItem Z = new ListViewItem("最高分");
            Z.SubItems.AddRange(new string[] { Chimax.ToString(), Engmax.ToString(), Mathmax.ToString() });
            listView1.Items.Add(Z);
            ListViewItem A = new ListViewItem("最低分");
            A.SubItems.AddRange(new string[] { Chimin.ToString(), Engmin.ToString(), Mathmin.ToString() });
            listView1.Items.Add(A);

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //搜尋起
            int GradeStart = Convert.ToInt32(txtQueryStart.Text);
            //搜尋迄
            int GradeEnd = Convert.ToInt32(txtQueryEnd.Text);

            //搜尋全域集合分數符合者
            List<Class_grade> query = Global_GradeList.Where(o => o.Chi <= GradeEnd && o.Chi >= GradeStart).ToList();

            listView.Items.Clear();

            //依照搜尋結果去重新塞入Item至ListView
            if (query != null && query.Count > 0)
            {
                foreach (Class_grade grade in query)
                {
                    ListViewItem item = new ListViewItem(grade.Name);//宣告一個新的ListViewItem() ()為第一欄的東西
                                                                     //item.SubItems.Add(Mygrade.Chi.ToString());//追加子項目(第二攔)

                    item.SubItems.AddRange(new string[] { grade.Chi.ToString(),grade.Eng.ToString(),grade.Math.ToString()
                                                         ,grade.totalponit().ToString(),grade.average().ToString()
                                                         ,grade.minpoint(),grade.maxpoint()});//純顯示出來
                    listView.Items.Add(item);
                }
            }

        }

        private void btnremove_Click_1(object sender, EventArgs e)
        {
            listView.Items.RemoveAt(listView.Items.Count - 1);
            //移除全域集合最後一項
            Global_GradeList.RemoveAt(Global_GradeList.Count - 1);
        }
    }
}
