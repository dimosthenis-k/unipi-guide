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
    public partial class Comments : Form
    {

        string path = "data_table_2.db";
        //string cs = @"URI=file" + Application.StartupPath + "\\data_table_2.db";
        string cs = "Data source=data_table.db;Version=3";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Comments()
        {
            InitializeComponent();

            // comments form colors
            this.BackColor = ColorTranslator.FromHtml("#222C54");
            this.submit_comment_button.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            this.submit_comment_button.BackColor = ColorTranslator.FromHtml("#A22631");

            //label colors
            this.username_comments_label.ForeColor = ColorTranslator.FromHtml("#A22631");
            this.comment_label.ForeColor = ColorTranslator.FromHtml("#A22631");
            this.preview_comments_label.ForeColor = ColorTranslator.FromHtml("#A22631");


        }
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test2";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            Create_db();
        }
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test2(username text,comments text)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                }
            }
            else
            {
                Console.WriteLine("Database cannot create");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO test2(username,comments) VALUES(@username,@comments)";

                string USERNAME = textBox1.Text;
                string COMMENTS = textBox2.Text;
                


                cmd.Parameters.AddWithValue("@username", USERNAME);
                cmd.Parameters.AddWithValue("@comments", COMMENTS);
                

                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Username";
                dataGridView1.Columns[1].Name = "Comments";
                
                string[] row = new string[] { USERNAME, COMMENTS };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot insert data");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
