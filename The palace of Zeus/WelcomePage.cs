using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Media.SpeechSynthesis;
namespace The_palace_of_Zeus
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistryAndSigning newpage= new RegistryAndSigning();
            newpage.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
