using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_palace_of_Zeus;

namespace The_palace_of_Zeus
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
