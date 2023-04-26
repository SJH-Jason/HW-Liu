using Frm_Clac;
using Frm_Hello;
using Frm_Loan;
using Lab_Method;
using Lab_Note;
using Lab_Picturedrawer;
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
    public partial class homework : Form
    {
        public homework()
        {
            InitializeComponent();
        }

        private void StructForm_Click(object sender, EventArgs e)
        {
            Frm_Struct Grade = new Frm_Struct();
            Grade.Show();
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            Hello hello = new Hello();
            hello.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clac clac = new Clac();
            clac.Show();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PictureDrawer drawer = new PictureDrawer();
            drawer.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            doforwhile For = new doforwhile();
            For.Show();
        }
    }

}
