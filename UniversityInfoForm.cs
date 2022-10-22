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
    public partial class UniversityInfoForm : Form
    {
        public UniversityInfoForm()
        {
            InitializeComponent();
        }

        private void UniversityInfoForm_Load(object sender, EventArgs e)
        {   

            // form background color
            this.BackColor = ColorTranslator.FromHtml("#222C54");

            lblocation.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            lbhistory.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            lbroam.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // displaying about info
            MessageBox.Show("Developed by: Karampinas Dimosthenis & Simotas Iasonas as part of Rapid Application Development Course :)");
        }

        private void lblocation_Click(object sender, EventArgs e)
        {   
            // navigating to map location on click
            unipi_browser.Navigate("https://www.google.com/maps/place/University+of+Piraeus/@37.9415179,23.6506794,17z/data=!3m1!4b1!4m5!3m4!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!8m2!3d37.9415137!4d23.6528681");
        }

        private void lbhistory_Click(object sender, EventArgs e)
        {
            unipi_browser.Navigate("https://www.unipi.gr/unipi/el/istoria1.html");
        }

        private void lbroam_Click(object sender, EventArgs e)
        {
            unipi_browser.Navigate("https://www.unipi.gr/unipi/el/perihghsh.html");
        }
    }
}
