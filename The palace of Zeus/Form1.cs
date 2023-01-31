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
    public partial class Form1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
