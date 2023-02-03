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
    public partial class Form4 : Form
    {
        private bool isPoolOccupied = false;

        public Form4()
        {
            InitializeComponent();
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

            if (checkBox6.Checked)
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