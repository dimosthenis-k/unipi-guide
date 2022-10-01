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
            new ToolTip().SetToolTip(saveiconpb, "Αποθήκευση πληροφοριών σε αρχείο txt");

        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            // setting save icon location
            saveiconpb.ImageLocation = "./resources/saveicon.png";


        }
    }
}
