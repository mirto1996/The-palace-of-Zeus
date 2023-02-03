using System;
using System.Windows.Forms;

namespace The_palace_of_Zeus
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            // Initialize checkbox 1 for "Lights On/Off"
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Text = "Lights On/Off";
            checkBox1.Location = new Point(10, 10);
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            this.Controls.Add(checkBox1);

            // Initialize checkbox 2 for "Air-condition On/Off"
            CheckBox checkBox2 = new CheckBox();
            checkBox2.Text = "Air-condition On/Off";
            checkBox2.Location = new Point(10, 35);
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            this.Controls.Add(checkBox2);

            // Initialize checkbox 3 for "TV On/Off"
            CheckBox checkBox3 = new CheckBox();
            checkBox3.Text = "TV On/Off";
            checkBox3.Location = new Point(10, 60);
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            this.Controls.Add(checkBox3);

            // Initialize checkbox 4 for "Radio On/Off"
            CheckBox checkBox4 = new CheckBox();
            checkBox4.Text = "Radio On/Off";
            checkBox4.Location = new Point(10, 85);
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            this.Controls.Add(checkBox4);
        }

        // Event handler for checkbox 1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                MessageBox.Show("Lights On");
            }
            else
            {
                MessageBox.Show("Lights Off");
            }
        }

        // Event handler for checkbox 2
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                MessageBox.Show("Air-condition On");
            }
            else
            {
                MessageBox.Show("Air-condition Off");
            }
        }

        // Event handler for checkbox 3
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                MessageBox.Show("TV On");
            }
            else
            {
                MessageBox.Show("TV Off");
            }
        }

        // Event handler for checkbox 4
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                MessageBox.Show("Radio On");
            }
            else
            {
                MessageBox.Show("Radio Off");
            }
        }
    }
}