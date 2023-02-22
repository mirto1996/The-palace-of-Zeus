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
    public partial class BAR : Form
    {
        public string username;
        int tries;
        public double price;
        public BAR(string name)
        {
            InitializeComponent();
            this.username = name;
        }

        private void BAR_Load(object sender, EventArgs e)
        {
            
            label1.Visible = false;
            label3.Visible = false;
            MessageBox.Show("Eπιλέξτε το προιόν που θέλετε να αγoράσετε πατώντας το ανάλογο κουμπί");
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            if(tries==1)
            {
                this.Close();
                PAY X = new PAY(price,username);
                X.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text =  " Νερό";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button2.Enabled = true;
            price+=0.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text =   " COCA-COLA";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button3.Enabled = true;
            price += 2.00;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label1.Text = " ΠΑΤΑΤΑΚΙΑ ΜΕ ΡΙΓΑΝΗ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button4.Enabled = true;
            price += 2.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            label1.Text = " ΠΑΤΑΤΑΚΙΑ ΜΕ ΚΛΑΣΣΙΚΗ ΓΕΥΣΗ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button5.Enabled = true;
            price += 2.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = " ΠΟΥΡΑΚΙΑ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button6.Enabled = true;
            price += 4.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = " ΜΠΥΡΑ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button7.Enabled = true;
            price += 5.00;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = " ΚΟΚΤΕΙΛ ΤΩΝ ΘΕΩΝ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button8.Enabled = true;
            price += 7.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = " ΜΠΙΣΚΟΤΑ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button9.Enabled = true;
            price += 2.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = " BAKE ROLLS";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button10.Enabled = true;
            price += 1.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = " ΑΝΑΨΥΚΤΙΚΟ ΝΕΚΤΑΡ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button11.Enabled = true;
            price += 2.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = " ΑΜΒΡΟΣΙΑ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button12.Enabled = true;
            price += 14.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = " ΣΟΚΟΛΑΤΑ";
            price = 0;
            tries = 0;
            label1.Visible = true;
            button13.Enabled = true;
            price += 2.50;
            label3.Visible = true;
            label3.Text = "Ποσό χρέωσης :" + price.ToString();
            tries++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu main_menu = new MainMenu(username);
            main_menu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Καλησπέρα, πως μπορώ να σας εξυπηρετήσω;";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine + "Δώστε μου λίγο χρόνο να ελέγξω διαθεσιμότητα");
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSend.PerformClick();
            }
        }
    }
}