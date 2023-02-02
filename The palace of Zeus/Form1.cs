using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Documents;
using System.Windows.Forms;


namespace The_palace_of_Zeus
{
    public partial class Form1 : Form
    {
        private bool isPoolOccupied = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ολοκλήρωση γεμίσματος σε δέκα λεπτά");
        }

        private void Evacuate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ολοκλήρωση αδειάσματος σε δέκα λεπτά");
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show("Τα φώτα άνοιξαν");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("Τα φώτα έκλεισαν");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Ο Συναργεμός ενεργοποιήθηκε");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                MessageBox.Show("Ο Συναργεμός απενεργοποιήθηκε");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                MessageBox.Show("Ο αισθητήρας ενεργοποιήθηκε");
            }
            else
            {
                MessageBox.Show("Ο αισθητήρας απενεργοποιήθηκε");
            }
        }
    }
}











