using Microsoft.Data.Sqlite;
using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_palace_of_Zeus
{
    public partial class RegistryAndSigning : Form
    {
        string dbcon = @"Data Source=ZEUS.db;Version=3;";
        string path = "ZEUS.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\ZEUS.db";
        SQLiteConnection sqlite_conn;
        public RegistryAndSigning()
        {
            InitializeComponent();
        }

        private void RegistryAndSigning_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             sqlite_conn = new SQLiteConnection(cs);
            

           
            sqlite_conn.Open();
            SQLiteCommand cmd = new SQLiteCommand( sqlite_conn);
            SQLiteCommand cmd1 = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr;
            cmd.CommandText= "INSERT INTO customers(USERNAME,PASSWORD) values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd1.CommandText = "SELECT * FROM  customers WHERE USERNAME='"+ textBox1.Text + "'";
            bool flag = true;
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                if (dr["USERNAME"].ToString() == textBox1.Text)
                {
                    flag = false;
                    MessageBox.Show("Το συγκεκριμένο Username  χρησιμοποιείται από άλλο χρήστη, παρακαλώ επιλέξτε άλλο");
                    break;
                }
            }
            dr.Close();
            if (flag == true)
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Μόλις κάνατε εγγραφή στην εφαρμογή του Παλατιού του Δία");
                flag = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd2 = new SQLiteCommand(sqlite_conn);      
            cmd2.CommandText = "SELECT * FROM  customers WHERE USERNAME='" + textBox1.Text + "' AND PASSWORD='" + textBox2.Text + "'";
            bool flag = true;
            SQLiteDataReader dr1;
            try { 
                dr1 = cmd2.ExecuteReader();
                flag = false;
                while (dr1.Read())
                {
                    if (dr1["USERNAME"].ToString() == textBox1.Text && dr1["PASSWORD"].ToString() == textBox2.Text)
                    {
                        flag = true;
                        this.Hide();
                        MainMenu main_menu = new MainMenu();
                        main_menu.Show();
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Μη έγκυρο username ή Password");
                }
                dr1.Close();
            }
            catch
            {
                MessageBox.Show("Μη έγκυρο username ή Password");
            }

          
            
        }
    }
}
