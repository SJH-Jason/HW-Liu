using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Method
{
    public partial class doforwhile : Form
    {
        public doforwhile()
        {
            InitializeComponent();
        }

        private void btn九九_Click(object sender, EventArgs e)
        {


            string result = "";

            for (int num = 2; num < 10; num++)
            {
                for (int num1 = 1; num1 < 10; num1++)
                {
                    //result += num.ToString() + "*" + num1.ToString() + "=" + (num * num1).ToString() ;
                    result += ($"{num}*{num1}={num * num1}\n");
                 
                }
                result = result + "\n\r";
               
            }
            labelShow.Text = "九九乘法表\n"+result;
        }
    }
           
        
    }

