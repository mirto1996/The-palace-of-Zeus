using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_palace_of_Zeus
{
    public partial class Form2 : Form
    {
        public string username;
        string cs = @"URI=file:" + Application.StartupPath + "\\ZEUS.db";
        SQLiteConnection sqlite_conn;
        public Form2(string name)
        {
            InitializeComponent();
            this.username = name;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Τα φώτα άνοιξαν");
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("Τα φώτα έσβησαν");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show("Το air-condition ενεργοποίηθηκε");
            }
            if (checkBox4.Checked)
            {
                MessageBox.Show("Το air-condition απενεργοποιήθηκε");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                MessageBox.Show("Η TV άνοιξε");
            }
            if (checkBox6.Checked)
            {
                MessageBox.Show("Η TV απενεργοποιήθηκε");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                MessageBox.Show("Το radio άνοιξε");
            }
            if (checkBox8.Checked)
            {
                MessageBox.Show("Το radio έκλεισε");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu main_menu = new MainMenu(username);
            main_menu.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr;
            cmd.CommandText = "SELECT * FROM  customers WHERE USERNAME='" + username + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["USERNAME"].ToString() == username)
                {

                    label6.Text = "Δωμάτιο: No " + dr["ID"].ToString();
                    break;
                }
            }
            dr.Close();
        }
    }
}



