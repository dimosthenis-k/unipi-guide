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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();

            //setting save icon hover text
            new ToolTip().SetToolTip(saveiconpb, "Αποθήκευση πληροφοριών");

        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            // setting save icon location
            saveiconpb.ImageLocation = "./resources/saveicon.png";


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
    }
}
