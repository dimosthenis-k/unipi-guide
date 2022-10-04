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
    public partial class Form2 : Form
    {
        string path = "data_table.db";
        //string cs = @"URI=file" + Application.StartupPath + "\\data_table.db";
        string cs = "Data source=data_table.db;Version=3";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test(username text,email text, password text)";
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

        private void Form2_Load(object sender, EventArgs e)

        {
            Create_db();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO test(username,email,password) VALUES(@username,@email,@password)";

                string USERNAME = textBox1.Text;
                string EMAIL = textBox2.Text;
                string PASSWORD = textBox3.Text;


                cmd.Parameters.AddWithValue("@username", USERNAME);
                cmd.Parameters.AddWithValue("@email", EMAIL);
                cmd.Parameters.AddWithValue("@password", PASSWORD);

                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Username";
                dataGridView1.Columns[1].Name = "Email";
                dataGridView1.Columns[2].Name = "Password";
                string[] row = new string[] { USERNAME, EMAIL,PASSWORD };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot insert data");
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}

