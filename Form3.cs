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


        private int imageNumber = 1;

        // function that swaps slideshow picturebox pictures
        private void loadNextImage()
        {
            if (imageNumber == 7)
            {
                imageNumber = 1;
            }
            slideshow_picturebox.ImageLocation = String.Format(@".\resources\slideshow\{0}.jpg", imageNumber);
            imageNumber++;
        }



        public Form3()
        {
            InitializeComponent();

            // setting form3 colors
            this.BackColor = ColorTranslator.FromHtml("#222C54");           //blue


            main_menu_label.ForeColor = ColorTranslator.FromHtml("#A22631");
            welcome_label.ForeColor = ColorTranslator.FromHtml("#A22631");      // red

            // starting slideshow timer on form load
            slideshow_timer.Enabled = true;

            // hiding log in form
            // form1.ActiveForm.Hide();

            // form3 button colors
            university_section_button.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            university_section_button.BackColor = ColorTranslator.FromHtml("#A22631");

            schools_section_button.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            schools_section_button.BackColor = ColorTranslator.FromHtml("#A22631");

            services_section_button.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            services_section_button.BackColor = ColorTranslator.FromHtml("#A22631");

            contact_section_button.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            contact_section_button.BackColor = ColorTranslator.FromHtml("#A22631");

            calendar_section_button.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            calendar_section_button.BackColor = ColorTranslator.FromHtml("#A22631");

            ratings_section_button.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            ratings_section_button.BackColor = ColorTranslator.FromHtml("#A22631");

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

        private void slideshow_timer_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void main_menu_label_Click(object sender, EventArgs e)
        {

        }

        private void schools_section_button_Click(object sender, EventArgs e)
        {
            SchoolsForm schools = new SchoolsForm();
            schools.Show();
        }

        private void calendar_section_button_Click(object sender, EventArgs e)
        {
            calendarForm calendar = new calendarForm();
            calendar.Show();
        }

        private void university_section_button_Click(object sender, EventArgs e)
        {
            UniversityInfoForm info = new UniversityInfoForm();
            info.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (!form1.getUserStatus())
            {
                services_section_button.Enabled = false;
                ratings_section_button.Enabled = false;
            }
        }

        private void contact_section_button_Click(object sender, EventArgs e)
        {
            ContactForm contact = new ContactForm();
            contact.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                DialogResult res;
                res = MessageBox.Show("Θέλεις να αποχωρήσεις;", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    this.Show();
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημοσθένης Καραμπίνας-Ιάσονας Σιμώτας");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Calendar cal = new Calendar();
            //cal.Show();
        }

        private void ratings_section_button_Click(object sender, EventArgs e)
        {
            if (form1.isUserLoggedIn)
            {
                Comments comments = new Comments();
                comments.Show();
            }
        }
    }
}
