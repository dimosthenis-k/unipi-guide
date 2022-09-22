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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // displaying about info
            MessageBox.Show("Developed by: Karampinas Dimosthenis & Simotas Iasonas as part of Rapid Application Development Course :)");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // exiting application when clicking on menu strip Exit button
            Application.Exit();
        }
    }
}
