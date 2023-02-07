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
    public partial class PisineSelection : Form
    {
        public string username;
        public int id;
        string cs = @"URI=file:" + Application.StartupPath + "\\ZEUS.db";
        SQLiteConnection sqlite_conn;
        public PisineSelection(string name,int id)
        {
            InitializeComponent();
            this.username = name;
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 p = new Form1(username,id);
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection(cs);
            sqlite_conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(sqlite_conn);
            SQLiteCommand cmd1 = new SQLiteCommand(sqlite_conn);
            SQLiteDataReader dr,DR2;
            cmd.CommandText = "SELECT COUNT(ID) FROM  ROOMS WHERE GENERALALARM='ON'";
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            try {
                cmd1.CommandText = "SELECT ID FROM  ROOMS WHERE GENERALALARM='ON'";
                dr = cmd1.ExecuteReader();
                dr.Read();
                Int32 ID = Convert.ToInt32(dr["ID"]);
                SQLiteCommand cmd2 = new SQLiteCommand(sqlite_conn);
                cmd2.CommandText = "SELECT USERNAME FROM  customers WHERE ID=" + ID.ToString() + "";
                DR2 = cmd2.ExecuteReader();
                DR2.Read();
                if (count == 0 || DR2["USERNAME"].ToString() == username)
                {
                    this.Close();
                    Form3 form3 = new Form3(username,id);
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Υπάρχει ενεργοποιημένος συναγερμός και δεν μπορείτε να παραμετροποιήσετε την μεγάλη πισίνα");
                }
            }catch {
                if(count == 0) { 
               
                        this.Close();
                        Form3 form3 = new Form3(username,id);
                        form3.Show();
                }
                else { 
                    
                        MessageBox.Show("Υπάρχει ενεργοποιημένος συναγερμός και δεν μπορείτε να παραμετροποιήσετε την μεγάλη πισίνα");
                }
            }       
        }

    

        private void PisineSelection_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu main_menu = new MainMenu(username);
            main_menu.Show();
        }
    }
}
