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
        public string number;
        string cs = @"URI=file:" + Application.StartupPath + "\\ZEUS.db";
        SQLiteConnection sqlite_conn;
        public Form2(string name)
        {
            InitializeComponent();
            this.username = name;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkBox2.Checked = false;
                MessageBox.Show("Τα φώτα άναψαν");

                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET LIGHTS='ON' WHERE ID=" + number + "";
                cmd.ExecuteNonQuery();
            }


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked && checkBox3.Checked)
            {
                checkBox4.Checked = false;
                MessageBox.Show("Το aircondition είναι ανοιχτό");
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET AIRCONDITION='ON' WHERE ID=" + number + "";
                cmd.ExecuteNonQuery();
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked && checkBox6.Checked)
            {
                checkBox6.Checked = false;
                MessageBox.Show("Η τηλεόραση άναψε");
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET TV='ON' WHERE ID=" + number + "";
                cmd.ExecuteNonQuery();
            }


        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox7.Checked && checkBox8.Checked)
            {
                checkBox8.Checked = false;
                MessageBox.Show("Το ραδιόφωνο άναψε");
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET RADIO='ON' WHERE ID=" + number + "";
                cmd.ExecuteNonQuery();
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
            SQLiteCommand cmd2 = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr;
            SQLiteDataReader dr2;
            cmd.CommandText = "SELECT * FROM  customers WHERE USERNAME='" + username + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["USERNAME"].ToString() == username)
                {

                    label6.Text = "Δωμάτιο: No " + dr["ID"].ToString();
                    number = dr["ID"].ToString();
                    cmd2.CommandText = "SELECT * FROM ROOMS WHERE ID='" + dr["ID"].ToString() + "'";
                    dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        if (dr2["AIRCONDITION"].ToString() == "OFF")
                        {
                            checkBox4.Checked = true;
                        }
                        else
                        {
                            checkBox3.Checked = true;
                        }
                        numericUpDown1.Value = Convert.ToInt32(dr2["TEMP"]);
                        if (dr2["TV"].ToString() == "OFF")
                        {
                            checkBox6.Checked = true;
                        }
                        else
                        {
                            checkBox5.Checked = true;
                        }
                        if (dr2["RADIO"].ToString() == "OFF")
                        {
                            checkBox8.Checked = true;
                        }
                        else
                        {
                            checkBox7.Checked = true;
                        }
                        if (dr2["LIGHTS"].ToString() == "OFF")
                        {
                            checkBox2.Checked = true;
                        }
                        else
                        {
                            checkBox1.Checked = true;
                        }
                    }
                    dr2.Close();
                    break;
                }
            }
            dr.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkBox1.Checked = false;
                MessageBox.Show("Τα φώτα έσβησαν");
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET LIGHTS='OFF' WHERE ID=" + number + "";
                cmd.ExecuteNonQuery();
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && checkBox4.Checked)
            {
                checkBox3.Checked = false;
                MessageBox.Show("Το aircondition είναι κλειστό");
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET AIRCONDITION='OFF' WHERE ID=" + number + "";
                cmd.ExecuteNonQuery();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox7.Checked && checkBox8.Checked)
            {
                checkBox7.Checked = false;
                MessageBox.Show("Το ραδιόφωνο έσβησε");
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET RADIO='OFF' WHERE ID=" + number + "";
                cmd.ExecuteNonQuery();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked && checkBox6.Checked)
            {
                checkBox5.Checked = false;
                MessageBox.Show("Η τηλεόραση έσβησε");
                sqlite_conn = new SQLiteConnection(cs);
                sqlite_conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
                cmd.CommandText = "UPDATE ROOMS SET TV='OFF' WHERE ID=" + number + "";
                cmd.ExecuteNonQuery();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
            cmd.CommandText = "UPDATE ROOMS SET TEMP=" + numericUpDown1.Value.ToString() + " WHERE ID=" + number + "";
            cmd.ExecuteNonQuery();
        }
    }
}



