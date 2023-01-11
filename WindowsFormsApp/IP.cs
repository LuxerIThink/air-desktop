using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SharedVariables;

namespace WindowsFormsApp
{
    

    public partial class IP : UserControl
    {
        public IP()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void IPconf_Click(object sender, EventArgs e)
        {
            SharedVariables.SetIP(metroTextBox1.Text);
            SharedVariables.SetPORT(metroTextBox2.Text);
            Label_IP.Text = ShowIP();
            Label_PORT.Text = ShowPort();
        }

        
    }
}
