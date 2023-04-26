using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_StructForm.MyClass;

namespace Lab_StructForm
{
    public partial class Frm_Struct : Form
    {
        string name = "";
        int chi = 0;
        int eng = 0;
        int math = 0;
        Grade grade;
        public Frm_Struct()
        {
            InitializeComponent();
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            grade.Name = Name1.Text;
            grade.Chi = Convert.ToInt32(Chi1.Text);
            grade.Eng = Convert.ToInt32(Eng1.Text);
            grade.Math = Convert.ToInt32(Math1.Text);
            
           
        }
        private void vtnsaveshow_Click(object sender, EventArgs e)
        {
           
             groupBox2.Text=  "姓名 :" + grade.Name +"\n"+
             "國文:" + grade.Chi.ToString() + "\n"+
             "英文:" + grade.Eng.ToString() +"\n"+
             "數學:" + grade.Math.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            grade.Chinese = "國文";
            grade.English = "英文";
            grade.Mathematics = "數學";

            grade.Name = Name1.Text;
            grade.Chi = Convert.ToInt32(Chi1.Text);
            grade.Eng = Convert.ToInt32(Eng1.Text);
            grade.Math = Convert.ToInt32(Math1.Text);

            if (grade.Chi > grade.Eng && grade.Eng > grade.Math)
            {
                groupBox3.Text = "最高成績為:" + grade.Chinese + grade.Chi + "\n" +
                                 "最低成績為:" + grade.Mathematics + grade.Math; 
            }

            else if (grade.Eng > grade.Chi && grade.Chi > grade.Math)
            {
                groupBox3.Text = "最高成績為:" + grade.English + grade.Eng + "\n" +
                                 "最低成績為:" + grade.Mathematics + grade.Math;
            }
            else if (grade.Math > grade.Chi&&grade.Chi>grade.Eng)
            {
                groupBox3.Text = "最高成績為:" + grade.Mathematics + grade.Math + "\n" +
                                 "最低成績為:" + grade.English + grade.Eng;
            }

        }

       
    }
            
            
}
                

            
        

        
    
