using Frm_Clac;
using Frm_Hello;
using Frm_Loan;
using Frm_Picture_viewer;
using Frm_StudentGrade;
using Lab_Alarm;
using Lab_Guess;
using Lab_Method;
using Lab_Note;
using Lab_Picturedrawer;
using Lab_PosPos;
using Lab_screen;
using Lab_studentgrade_list;
using Lab_XOGAME;
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

        private void button16_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm();
            alarm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentgrade grade = new studentgrade();
            grade.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gradelist grl = new gradelist();
            grl.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            XOGame xo = new XOGame();
            xo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Pos pos = new Frm_Pos();
            pos.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Picvi pic = new Picvi();
            pic.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            screen  lo = new screen();
            lo.Show();
        }
    }

}
