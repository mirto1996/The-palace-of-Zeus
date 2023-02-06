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
    
    public partial class MainMenu : Form
    {

        string dbcon = @"Data Source=ZEUS.db;Version=3;";
        string path = "ZEUS.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\ZEUS.db";
        SQLiteConnection sqlite_conn;
        public string username;
        public int id;
        public MainMenu(string name)
        {
            InitializeComponent();
            this.username = name;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            label2.Text = "ΚΑΛΩΣ ΗΡΘΑΤΕ  " + username ;
            sqlite_conn = new SQLiteConnection(cs);



            sqlite_conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr;
            cmd.CommandText = "SELECT ID FROM  customers WHERE USERNAME='" + username  + "'";
            dr= cmd.ExecuteReader();
            dr.Read();
            id = Convert.ToInt32(dr["ID"]);
            dr.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();   
            BAR C= new BAR(username);
            C.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 X = new Form2(username);
            X.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Y = new Form4(username);
            Y.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PisineSelection f= new PisineSelection(username,id);  
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistryAndSigning x = new RegistryAndSigning();
            x.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 x = new Form6();
            x.Show();
        }
    }
}
