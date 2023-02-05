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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PAY X= new PAY(price);
            X.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            price+=0.50;
            tries++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            price += 2.00;
            tries++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            price += 2.50;
            tries++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            price += 2.50;
            tries++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            price += 4.50;
            tries++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            price += 5.00;
            tries++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            price += 7.50;
            tries++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
            price += 2.50;
            tries++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            price += 1.50;
            tries++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            price += 2.50;
            tries++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            price += 14.50;
            tries++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            price += 2.50;
            tries++;
        }
    }
}
