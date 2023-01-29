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
            SQLiteConnection sqlite_conn = new SQLiteConnection(cs);
            

           
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
    }
}
