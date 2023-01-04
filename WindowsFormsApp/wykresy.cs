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
    public partial class wykresy : UserControl
    {
        public wykresy()
        {
            InitializeComponent();
            timer.Start();
        }

        private void wykresy_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            chart1.Series["Data"].Points.AddY(rnd.Next(1, 10));
            chart2.Series["Data"].Points.AddY(rnd.Next(1, 100));
            chart3.Series["Data"].Points.AddY(rnd.Next(0, 10));
            chart4.Series["Data"].Points.AddY(rnd.Next(10, 30));
            chart5.Series["Data"].Points.AddY(rnd.Next(0, 50));
            chart6.Series["Data"].Points.AddY(rnd.Next(200, 300));
        }
    }
}
