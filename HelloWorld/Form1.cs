using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            lblDisplayInfo.Text = "Hello World!";
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Clicking my Button!");
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            lblDisplayInfo.Text = "Goodbye World!";
        }
    }
}
