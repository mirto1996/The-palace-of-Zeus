using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_palace_of_Zeus
{
    
    public partial class MainMenu : Form
    {
        public string username;

        public MainMenu(string name)
        {
            InitializeComponent();
            this.username = name;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            label2.Text = "ΚΑΛΩΣ ΗΡΘΑΤΕ  " + username ;
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
            PisineSelection f= new PisineSelection(username);  
            f.Show();
        }
    }
}
