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
    public partial class PisineSelection : Form
    {
        public string username;
        public PisineSelection(string name)
        {
            InitializeComponent();
            this.username = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 p = new Form1(username);
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 y= new Form3(username);
            y.Show();  
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
