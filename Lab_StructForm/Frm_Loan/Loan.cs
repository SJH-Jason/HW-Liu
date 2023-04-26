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

        private void button1_Click(object sender, EventArgs e)
        {
            int MonthMoney = CalMonthmoney();
            MessageBox.Show("月付額為:" + MonthMoney.ToString() + "元");
        }


        public int CalMonthmoney()
        {
            int Loanmoney = Convert.ToInt32(textBox1.Text);
            int Years = Convert.ToInt32(textBox2.Text);
            double Rate = Convert.ToDouble(textBox3.Text);
            int Firstmoney = Convert.ToInt32(textBox4.Text);
            // 每月應付本息金額之平均攤還率 ＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            double Monthrate = Rate / 12 / 100;
            int months = Years * 12;
            double moneyrate = ((Math.Pow(1 + Monthrate, months) * Monthrate) / ((Math.Pow(1 + Monthrate, months)) - 1));
            //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 
            int MonthMoney = Convert.ToInt32(Math.Round(Loanmoney * moneyrate));
            return MonthMoney;
        }


        private int CalTotalMoney()
        {

            int Years = Convert.ToInt32(textBox2.Text);
            int months = Years * 12;
            int Monthmoney = CalMonthmoney();
            int Totalmoney = (Monthmoney * months);
            return Totalmoney;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Totalmoney = CalTotalMoney();
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
