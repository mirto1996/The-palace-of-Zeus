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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Δουρείος Ίππος κατευθύνεται μπροστά");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Δουρείος Ίππος κατευθύνεται πίσω");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Δουρείος Ίππος κατευθύνεται δεξιά");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Δουρείος Ίππος κατευθύνεται αριστερά");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Η πόρτα άνοιξε");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Η πόρτα έκλεισε");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Η πόρτα είναι μισόκλειστη");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Θέση parking: Προαύλιο του Ναού του Δία");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Θέση parking: Κήπους του Ολύμπου");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Σκάλα διαθέσιμη");
        }
    }
}
