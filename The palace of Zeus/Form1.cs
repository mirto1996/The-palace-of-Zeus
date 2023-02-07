using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Documents;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Data.SQLite;
using Windows.Networking.NetworkOperators;

namespace The_palace_of_Zeus
{
    public partial class Form1 : Form
    {
        public string username;
        public int id;
        string cs = @"URI=file:" + Application.StartupPath + "\\ZEUS.db";
        SQLiteConnection sqlite_conn;
        public Form1(string name, int id)
        {
            InitializeComponent();
            this.username = name;
            this.id = id;
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && checkBox2.Checked)
            {
                checkBox2.Checked = false;
                MessageBox.Show("Τα φώτα της πισίνας άναψαν");

                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET POOLLIGHTS='ON' WHERE ID=" + id.ToString() + "";
                cmd.ExecuteNonQuery();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && checkBox2.Checked)
            {
                checkBox3.Checked = false;
                MessageBox.Show("Τα φώτα της πισίνας έκλεισαν");

                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET POOLLIGHTS='OFF' WHERE ID=" + id.ToString() + "";
                cmd.ExecuteNonQuery();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox4.Checked)
            {
                checkBox4.Checked = false;
                MessageBox.Show("Ο Συναργεμός ενεργοποιήθηκε");

                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET ALARM='ON' WHERE ID=" + id.ToString() + "";
                cmd.ExecuteNonQuery();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox4.Checked)
            {
                checkBox1.Checked = false;
                MessageBox.Show("Ο Συναργεμός απενεργοποιήθηκε");

                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET ALARM='OFF' WHERE ID=" + id.ToString() + "";
                cmd.ExecuteNonQuery();
            }

        
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

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr;
            cmd.CommandText = "SELECT * FROM ROOMS WHERE ID=" + id.ToString() + "";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr["POOLLIGHTS"].ToString() == "OFF")
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox3.Checked = true;
            }
            if (dr["ALARM"].ToString() == "OFF")
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox1.Checked = true;
            }
            numericUpDown1.Value = Convert.ToInt32(dr["WATERTEMP"]);
            trackBar1.Value = Convert.ToInt32(dr["WATERLEVEL"]);
            label1.Text = numericUpDown1.Value.ToString() + "°C";
            dr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString() + "°C";
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
            cmd.CommandText = "UPDATE ROOMS SET WATERTEMP=" + numericUpDown1.Value.ToString() + " WHERE ID=" + id.ToString() + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Οι επιλογές  επιβεβαιώθηκαν");
            SQLiteCommand cmd2 = new SQLiteCommand(sqlite_conn);
            cmd2.CommandText = "UPDATE ROOMS SET WATERLEVEL=" + trackBar1.Value.ToString() + " WHERE ID=" + id.ToString() + "";
            cmd2.ExecuteNonQuery();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}











