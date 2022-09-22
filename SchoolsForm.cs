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
    public partial class SchoolsForm : Form
    {
        public SchoolsForm()
        {
            InitializeComponent();

            // schoolsform form colors
            this.BackColor = ColorTranslator.FromHtml("#F7F2EB");

            // setting up logo
            schools_unipi_logo.Image = Image.FromFile(@"./resources/unipi-logo.png");


        }

        private void SchoolsForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
