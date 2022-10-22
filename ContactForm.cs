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



            // loading contact info text
            contact_info_textbox.LoadFile(".//resources//info.txt", RichTextBoxStreamType.PlainText);

            // setting save icon location
            saveiconpb.ImageLocation = "./resources/saveicon.png";

            // form background color
            this.BackColor = ColorTranslator.FromHtml("#222C54");

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveiconpb_Click(object sender, EventArgs e)
        {   
            // save file dialog parameters
            info_sfd.InitialDirectory = @"./";
            info_sfd.Title = "Αποθήκευση πληροφοριών";
            info_sfd.DefaultExt = "txt";

            if (info_sfd.ShowDialog() == DialogResult.OK)
            {
                contact_info_textbox.SaveFile(info_sfd.FileName, RichTextBoxStreamType.PlainText);
            }

        }
    }
}
