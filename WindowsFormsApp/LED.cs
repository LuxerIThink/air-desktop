using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class LED : UserControl
    {
        public LED()
        {
            InitializeComponent();
            timerbtn.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTrackBar4_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel1.Text = metroTrackBar4.Value.ToString();
            
        }

        private void metroTrackBar5_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel2.Text = metroTrackBar5.Value.ToString();
        }

        private void metroTrackBar6_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel3.Text = metroTrackBar6.Value.ToString();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(metroTrackBar4.Value, metroTrackBar5.Value, metroTrackBar6.Value);
        }

        private void timerbtn_Tick(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(metroTrackBar4.Value, metroTrackBar5.Value, metroTrackBar6.Value);
        }

        private void LED_Load(object sender, EventArgs e)
        {

        }
    }
}
