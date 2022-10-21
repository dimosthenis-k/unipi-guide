using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace unipi_tour_guide
{
    public partial class form1 : Form
    {


        // public bool to check user login
        public static bool isUserLoggedIn = false;
        
        public static bool getUserStatus()
        {
            return isUserLoggedIn;
        }

        public static void setUserStatus(bool status)
        {
            isUserLoggedIn = status;
        }

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

            // textbox colors
            this.username_textbox.BackColor = ColorTranslator.FromHtml("#F7F2EB");
            this.password_textbox.BackColor = ColorTranslator.FromHtml("#F7F2EB");

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

        private void signup_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form2 SignUp = new Form2();
            SignUp.Show();

            // disabling sign up labeling after clicking | prevents multiple sign up forms from appearing
            //signup_label.Enabled = false; 
        }

        private void no_account_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // public boolean to check if user is logged in from other forms
            bool isUserLoggedIn = false;

            // displaying guest user limitations notification
            MessageBox.Show("Σημαντικό: Μερικές από τις λειτουργίες της εφαρμογής δεν θα είναι διαθέσιμες αν συνεχίσετε ως επισκέπτης.");


            Form3 mainMenu = new Form3();
            mainMenu.Show();
            
        }
        SQLiteConnection conn = new SQLiteConnection("Data source=data_table.db;Version=3");
        private void login_button_Click(object sender, EventArgs e)
        {
           if (username_textbox.Text.Trim()=="" && password_textbox.Text.Trim()=="")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
           else
            {
                string query = "SELECT * FROM test WHERE username=@username_textbox AND password=@password_textbox";
                SQLiteConnection conn = new SQLiteConnection("Data source=data_table.db;Version=3");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username_textbox", username_textbox.Text);
                cmd.Parameters.AddWithValue("@password_textbox",password_textbox.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("You are Logged in", "Login Successful");
                    Form3 mainMenu = new Form3();
                    isUserLoggedIn = true;
                    mainMenu.Show();

                }
                else
                {
                    MessageBox.Show("Login Failed","Error");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Θέλεις να αποχωρήσεις;", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res==DialogResult.Yes)
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
    }
}
