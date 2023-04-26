using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace Frm_Picture_viewer
{
    public partial class picform : Form
    {
       
        public picform()

        {
            InitializeComponent();

        }
        public PictureBox  pic { get; set; }
        private void picform_Load(object sender, EventArgs e)
        {

            //report Report = new report();
            // Report.Loanmoney = Convert.ToInt32(textBox1.Text);

            pictureBox1.Image = pic.Image;




        }
    }
}

