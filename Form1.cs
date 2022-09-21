using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unipi_tour_guide
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            // setting up log in form images and colors

            banner_picturebox.Image = Image.FromFile(@"resources/unipi-banner.png");
            // banner background color RED
            banner_picturebox.BackColor = ColorTranslator.FromHtml("#A22631");

            // form background color BLUE
            this.BackColor = ColorTranslator.FromHtml("#222C54");

            // label colors
            this.username.ForeColor = ColorTranslator.FromHtml("#A22631");
            this.password.ForeColor = ColorTranslator.FromHtml("#A22631");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void banner_picturebox_Click(object sender, EventArgs e)
        {

        }
    }
}
