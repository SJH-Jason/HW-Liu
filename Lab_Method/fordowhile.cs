using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
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

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        int product = i * j;
            //        string formatted = product.ToString().PadLeft(2); // 使用 PadLeft 補齊為兩位數字
            //        Console.Write($"{j} x {i} = {formatted}\t"); // 使用制表符 \t 分隔每個數字
            //    }
            //    Console.WriteLine();



            string result = "";

            for (int num = 1; num < 10; num++)
            {
                for (int num1 = 2; num1 < 10; num1++)
                {
                    //result += num.ToString() + "*" + num1.ToString() + "=" + (num * num1).ToString();
                    result += ($" {num1}*{num}={num * num1}| ");

                }
                result = result + "\n\r";

            }
            labelShow.Text = "九九乘法表\n" + result;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100; int n2 = 200;
            labelShow.Text += ($"換位前n1:{n1},n2:{n2}\n");
            Swap(ref n1, ref n2);
            labelShow.Text += ($"換位後n1:{n1},n2:{n2}");
        }
        void Swap(ref int n1, ref int n2)
        {
            int T = n1;
            n1 = n2;
            n2 = T;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            labelShow.Text = "int陣列[";
            int[] arr07011 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = 0;
            for (int i = 0; i < arr07011.Length; i++)
            {
                sum += arr07011[i];
                labelShow.Text += arr07011[i].ToString() + ", ";
            }

            labelShow.Text += "]";
            labelShow.Text += "\r\n加總為: " + sum;



        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            labelShow.Text = "int陣列[";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int Max = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] > Max)
                {
                    Max = arr0711[i];
                }
                labelShow.Text += arr0711[i].ToString() + ", ";
            }

            labelShow.Text += "]";
            labelShow.Text += "\r\n最大值: " + Max;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            labelShow.Text = "int陣列[";
            int[] arr07011 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int Min = arr07011.Min();
            //int Min = 0;
            //for (int i = 0; i < arr07011.Length; i++)
            //{
            //if (arr07011[i] < Min)
            //{
            //    Min = arr07011[i];
            //}
            //     labelShow.Text += arr07011[i].ToString() + ", ";
            //}
            //   labelShow.Text += "]";
            //   labelShow.Text += "\r\n加總為: " + Min;
            //   labelShow.Text = Max.ToString();
            labelShow.Text = $"int陣列arr07011 = {{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }}\n最小值為 {Min}";



        }

        private void btn積數偶數_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txt1.Text);
            if (A % 2 == 0)
            {
                labelShow.Text = "輸入的數" + A + "為" + "偶數";

            }
            else
            {
                labelShow.Text = "輸入的數" + A + "為" + "奇數";
            }
        }

        private void btn陣列最大最小_Click(object sender, EventArgs e)
        {
            //labelShow.Text = "int陣列[";
            // int[] arr07011 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            // int Max = 0;
            // int Min = 0;
            // for (int i = 0; i < arr07011.Length; i++)
            // {
            //     if (arr07011[i] > Max)
            //     {
            //         Max = arr07011[i];
            //     }
            //     labelShow.Text += arr07011[i].ToString() + ", ";
            // }

            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int Min = arr0711.Min();
            int Max = arr0711.Max();
            labelShow.Text = $"int陣列arr0711 = {{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }}\n最大值為 {Max}\n最小值{Min}";


        }

        private void btn陣列字樣_Click(object sender, EventArgs e)
        {
            string[] arr0711 = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Ccount", "MotherFacker" };
            int count = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i].IndexOf('C') > -1 || arr0711[i].IndexOf('c')>-1)
                {
                    count++;
                }
            }
            labelShow.Text = "arr0711_Str : mother張   emma   迪克蕭   J40   Candy   Cindy   Ccount   MotherFacker" + "\n" +
               " 有C 及 c的名字共有" + count + "個";
        }

        private void btn二進位_Click(object sender, EventArgs e)
        {
            
            labelShow.Text = Convert.ToString(100,2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labelShow.Text = "";
        }

        private void btnMerryTree_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtrow.Text);
            {
                string str = "";
                for (int i=0; i < a; i++)
                    
                {
                    for(int j=0; j<=i ; j++)
                    {
                        str +="*";
                    }
                    str += "\r\n";
                }
                labelShow.Text = str;

                  //將i轉換成txtrow中填入的數字 並條件設定為txtrow的數字如果為多少就跳出幾行聖誕樹
                }
                
            }

        private void btn統計_Click(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            int[] arr07011 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            for(int i=0;i<arr07011.Length;i++)
            {
                if(arr07011[i] % 2 == 0)
                {
                    count++;
                }
                else
                {
                    count1++;
                }
                labelShow.Text = "int陣列arr0711 = [1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]"+"\n"+
                    "奇數共" + count1 + "\n" +
                    "偶數共" + count;

            }   
          
        }

        private void btn最長的名字_Click(object sender, EventArgs e)
        {
            string[] arr0711 = { "mother張", "emma", "迪克蕭","J40", "Candy","Cindy", "Ccount", "MotherFacker" };
            string result = "";
            for(int i=0;i<arr0711.Length;i++)
            {
               if (arr0711[i].Length>result.Length)
                {
                    result= arr0711[i];
                }
            }
            labelShow.Text = "陣列arr0711_Str[mother張   emma    迪克蕭   J40   Candy   Cindy   Ccount   MotherFacker]"+"\n"+
                "最長的名字"+ result;
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int from = Convert.ToInt32(txtFrom.Text);
            int to = Convert.ToInt32(txtTo.Text);
            int step = Convert.ToInt32(txtStep.Text);
            
            for(int i = from;i<=to;i+=step)
            {
                sum += i;
            }

            labelShow.Text = sum.ToString();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int from = Convert.ToInt32(txtFrom.Text);
            int to = Convert.ToInt32(txtTo.Text);
            int step = Convert.ToInt32(txtStep.Text);

            while (from <= to)
            {
                sum += from;
                from += step;
            }

            labelShow.Text = sum.ToString();
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int from = Convert.ToInt32(txtFrom.Text);
            int to = Convert.ToInt32(txtTo.Text);
            int step = Convert.ToInt32(txtStep.Text);

            do
            {
                sum += from;
                from += step;
            }
            while (from <= to);


            labelShow.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";

            int[,] a = new int[10, 10];

            int xlength = a.GetLength(0);
            int ylength = a.GetLength(1);
            for (int x = 0; x < xlength; x++)
            {
                for (int y = 0; y < ylength; y++)
                {
                    //基礎版
                    
                    if (x == 0 || x == xlength - 1 ||
                        y == 0 || y == ylength - 1 )
                    {
                        str += "1";
                    }
                    else
                    {
                        str += "0";

                    }
                    
                    //進階版
                   // str += Convert.ToString(Convert.ToInt32((x == 0 || x == xlength - 1 || y == 0 || y == ylength - 1)));
                }
                str += "\r\n";
            }

            labelShow.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";

            int[,] a = new int[10, 10];

            int xlength = a.GetLength(0);
            int ylength = a.GetLength(1);
            for (int x = 0; x < xlength; x++)
            {
                for (int y = 0; y < ylength; y++)
                {
                    //基礎版
                    /*
                    if (x == 0 || x == xlength - 1 ||
                        y == 0 || y == ylength - 1 )
                    {
                        str += "0";
                    }
                    else
                    {
                        str += "1";

                    }
                    */
                    //進階版
                    str += Convert.ToString(Convert.ToInt32(!(x == 0 || x == xlength - 1 || y == 0 || y == ylength - 1)));
                }
                str += "\r\n";
            }

            labelShow.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";

            int[,] a = new int[10, 10];

            int xlength = a.GetLength(0);
            int ylength = a.GetLength(1);
            for (int x = 0; x < xlength; x++)
            {
                for (int y = 0; y < ylength; y++)
                {
                    if((x+y)%2==0)
                    {
                        str += "1   ";
                    }
                    else 
                    {
                        str+= "0   ";
                    }
    
                    //基礎版
                    /*
                    if (((x+1)%2 != 0 && (y+1)%2 != 0) ||
                        ((x+1)%2 == 0 && (y+1)%2 == 0))
                    {
                        str += "1";
                    }
                    else
                    {
                        str += "0";

                    }
                    */
                    //進階版
                    //str += Convert.ToString(Convert.ToInt32(((x + 1) % 2 != 0 && (y + 1) % 2 != 0) || ((x + 1) % 2 == 0 && (y + 1) % 2 == 0)));
                }
                str += "\r\n";
            }

            labelShow.Text = str;
        }

        private void btn樂透_Click(object sender, EventArgs e)
        {
            labelShow.Text = "樂透號碼" + "\n";
            int[] number = new int[6];
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                number[i] = r.Next(1, 100);
                for (int j = 0; j < i; j++)
                {
                    while (number[j] == number[i]) //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    { 
                     
                        j = 0;// 如有重複，將變數j設為0，再次檢查(因為還是有重複的可能)
                        number[i] = r.Next(1, 100);//重新產生，存回陣列，亂數產生的範圍是1~100
                    }
                    
                }
                labelShow.Text += number[i].ToString()+" ";
            }
            
            





        }
    }
}





