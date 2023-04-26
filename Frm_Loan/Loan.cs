using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Loan
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }
        int Loanmoney;
        int Years;
        double Rate;
        int Firstmoney;
        double Monthrate; //宣告變數
        int months;
        double moneyrate;
        int MonthMoney;
        int Totalmoney;
     
        public int CalMonthmoney() //建立月付款的方法
        {
            Loanmoney = Convert.ToInt32(textBox1.Text);
            Years = Convert.ToInt32(textBox2.Text);
            Rate = Convert.ToDouble(textBox3.Text);
            Firstmoney = Convert.ToInt32(textBox4.Text);
            // 每月應付本息金額之平均攤還率 ＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            Monthrate = Rate / 12 / 100;
            months = Years * 12;
            moneyrate = ((Math.Pow(1 + Monthrate, months) * Monthrate) / ((Math.Pow(1 + Monthrate, months)) - 1));
            //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 
            MonthMoney = Convert.ToInt32(Math.Round(Loanmoney * moneyrate));
            return MonthMoney;
        }
        private int CalTotalMoney()  //建立貸款總額的方法
        {
            Years = Convert.ToInt32(textBox2.Text);
            months = Years * 12;
            MonthMoney = CalMonthmoney();
            Totalmoney = (MonthMoney * months);
            return Totalmoney;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int MonthMoney = CalMonthmoney();
            MessageBox.Show("月付額為:" + MonthMoney.ToString() + "元");
        }
        private void button2_Click(object sender, EventArgs e)
        {
             Totalmoney = CalTotalMoney();
            MessageBox.Show("總付款 :" + Totalmoney.ToString() + "元");
        }
        private void button3_Click(object sender, EventArgs e)
        {
                report Report = new report();
                Report.Loanmoney = Convert.ToInt32(textBox1.Text);
                Report.Years = Convert.ToInt32(textBox2.Text);
                Report.Rate = Convert.ToInt32(textBox3.Text);
                Report.Monthmoney = CalMonthmoney();
                Report.Totalmoney = CalTotalMoney();
                Report.Show();
        }
    }
}
