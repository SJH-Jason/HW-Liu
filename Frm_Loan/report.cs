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

namespace Frm_Loan
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }
        public double Loanmoney { get; set; }//利用get set 回傳loan表單的值

        public int Years { get; set; }

        public double Rate { get; set; }
        public int Monthmoney { get; set; }

        public int Totalmoney { get; set; }

        
        private void report_Load(object sender, EventArgs e) //先講資料存在form中，form一打開就會顯示資料
        {
            textBox1.Text = Loanmoney.ToString();
            textBox2.Text = Years.ToString();
            textBox3.Text = Rate.ToString();
            textBox4.Text = Monthmoney.ToString();
            textBox5.Text = Totalmoney.ToString();
        }
    }
      
 }

