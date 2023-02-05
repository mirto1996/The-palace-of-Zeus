using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace The_palace_of_Zeus
{
    public partial class PAY : Form
    {
        public double price;
        public string username;
        public PAY(double price,string username)
        {
            InitializeComponent();
            this.price = price;
            this.username = username;
        }

        private void PAY_Load(object sender, EventArgs e)
        {
            label4.Text = label4.Text +" "+ price.ToString()+ "€";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 16)
            {
                MessageBox.Show("O 16-ψήφιος κωδικός της κάρτας δεν είναι έγκυρος");
            }
            else if(textBox3.Text.Length != 3)
            {
                MessageBox.Show("O κωδικός ασφαλείας της κάρτας είναι λάθος ");
            }
            else
            {
                MessageBox.Show("Επεξεργασία πληρωμής ...");
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);
                MessageBox.Show("Επιτυχία!!! περιμέντε να παραλάβετε τα προιόντα σας");
                this.Close();
                MainMenu Y = new MainMenu(username);
                Y.Show();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu Y = new MainMenu(username);
            Y.Show();
        }
    }
}
