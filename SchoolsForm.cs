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

        private void button1_Click(object sender, EventArgs e)
        {
            school_info_textbox.LoadFile(".//resources//econ.txt", RichTextBoxStreamType.PlainText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            school_info_textbox.LoadFile(".//resources//maritime.txt", RichTextBoxStreamType.PlainText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            school_info_textbox.LoadFile(".//resources//finance.txt", RichTextBoxStreamType.PlainText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            school_info_textbox.LoadFile(".//resources//computerscience.txt", RichTextBoxStreamType.PlainText);
        }

        private void aboiutToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
