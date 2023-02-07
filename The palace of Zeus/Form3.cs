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
using The_palace_of_Zeus;

namespace The_palace_of_Zeus
{
    public partial class Form3 : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\ZEUS.db";
        SQLiteConnection sqlite_conn;
        public string username;
        public int id;
        public Form3(string name,int id)
        {
            InitializeComponent();
            this.username = name;
            this.id = id;
        }

      

        private void Form3_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr;
            cmd.CommandText = "SELECT * FROM ROOMS WHERE ID=" + id.ToString() + "";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr["GENERALALARM"].ToString() == "OFF")
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox3.Checked = true;
            }
            dr.Close();
            SQLiteCommand cmd1 = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr1;
            cmd1.CommandText = "SELECT * FROM POOL ";
            dr1 = cmd1.ExecuteReader();
            dr1.Read();
            if (dr1["LIGHTS"].ToString() == "OFF")
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox1.Checked = true;
            }
            numericUpDown1.Value = Convert.ToInt32(dr1["WATERTEMP"]);
            label1.Text = numericUpDown1.Value.ToString() + "°C";
            trackBar1.Value = Convert.ToInt32(dr1["WATERLEVEL"]);
            dr1.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked && checkBox1.Checked)
            {
                checkBox1.Checked = false;
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE POOL SET LIGHTS='ON'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Τα φώτα άναψαν");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && checkBox1.Checked)
            {
                checkBox2.Checked = false;
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE POOL SET LIGHTS='OFF'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Τα φώτα έκλεισαν");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && checkBox4.Checked)
            {
                checkBox4.Checked = false;
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET GENERALALARM='ON' WHERE ID=" + id + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ο Συναργεμός ενεργοποιήθηκε");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && checkBox4.Checked)
            {
                checkBox3.Checked = false;
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd1 = new SQLiteCommand(sqlite_conn);
                cmd1.CommandText = "UPDATE ROOMS SET GENERALALARM='OFF' WHERE ID=" + id + "";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Ο Συναργεμός απενεργοποιήθηκε");
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

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString() + "°C";
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
            cmd.CommandText = "UPDATE POOL SET WATERTEMP=" + numericUpDown1.Value.ToString() ;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Οι επιλογές  επιβεβαιώθηκαν");
            SQLiteCommand cmd2 = new SQLiteCommand(sqlite_conn);
            cmd2.CommandText = "UPDATE POOL SET WATERLEVEL=" + trackBar1.Value.ToString() + "";
            cmd2.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd2 = new SQLiteCommand(sqlite_conn);
            cmd2.CommandText = "UPDATE POOL SET SUM=SUM+1";
            cmd2.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();
            SQLiteCommand cmd2 = new SQLiteCommand(sqlite_conn);
            cmd2.CommandText = "UPDATE POOL SET SUM=SUM-1";
            cmd2.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();
            SQLiteCommand cmd2 = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr1;
            cmd2.CommandText = "SELECT SUM FROM  POOL";
            dr1 = cmd2.ExecuteReader();
            dr1.Read();
            Int32 SUM = Convert.ToInt32(dr1["SUM"]);
            MessageBox.Show("Η πισίνα έχει μέσα συνολικά "+SUM.ToString()+" άτομα");
        }
    }
}


