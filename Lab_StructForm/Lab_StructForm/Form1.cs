﻿using System;
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
    public partial class Form1 : Form
    {
        string name = "";
        int chi = 0;
        int eng = 0;
        int math = 0;
        Grade grade;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            grade.Name = Name1.Text;
            grade.Chi = Convert.ToInt32(Chi1.Text);
            grade.Eng = Convert.ToInt32(Eng1.Text);
            grade.Math = Convert.ToInt32(Math1.Text);
            
            
            //name = Name1.Text;
            //chi = Convert.ToInt32(Chi1.Text);
            //eng = Convert.ToInt32(Eng1.Text);
            //math = Convert.ToInt32(Math1.Text);
        }
        private void vtnsaveshow_Click(object sender, EventArgs e)
        {
           
            //grade.Name = Name1.Text;
            //grade.Chi = int.Parse(Chi1.Text);
            //grade.Eng = int.Parse(Eng1.Text);
            //grade.Math = int.Parse(Math1.Text);
           groupBox2.Text = "姓名 :" + grade.Name +"\n"+
             "國文:" + grade.Chi.ToString() + "\n"+
             "英文:" + grade.Eng.ToString() +"\n"+
            "數學:" + grade.Math.ToString();

            //label5.Text= $"\n姓名:{grade.Name},國文:{grade.Chi},英文:{grade.Eng},數學:{grade.Math}";

           // groupBox2.Text = ("姓名 :" + name + "\n" +
           // "國文 :" + chi.ToString() + "\n" +
            //"英文 :" + eng.ToString() + "\n" +
           // "數學 :" + math.ToString());

        }

    }
}