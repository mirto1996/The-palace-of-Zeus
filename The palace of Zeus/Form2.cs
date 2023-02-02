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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Τα φώτα άνοιξαν");
            }
            else
            {
                MessageBox.Show("Τα φώτα έσβησαν");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show("Το air-condition ενεργοποίηθηκε");
            }
            else
            {
                MessageBox.Show("Το air-condition απενεργοποιήθηκε");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                MessageBox.Show("Η TV άνοιξε");
            }
            else
            {
                MessageBox.Show("Η TV απενεργοποιήθηκε");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                MessageBox.Show("Το radio άνοιξε");
            }
            else
            {
                MessageBox.Show("Το radio έκλεισε");
            }
        }

    }
}



