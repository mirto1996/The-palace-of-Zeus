﻿using System;
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
        public BAR()
        {
            InitializeComponent();
        }

        private void BAR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PAY X= new PAY();
            X.Show();
        }
    }
}
