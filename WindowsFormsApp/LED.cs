using MetroFramework.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;


namespace WindowsFormsApp
{
    public partial class LED : UserControl
    {
        public LED()
        {
            InitializeComponent();
            timerbtn.Start();
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.ColumnCount = 8;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    button.Click += button_Click;
                    tableLayoutPanel1.Controls.Add(button, i, j);
                }
            }
            this.Controls.Add(tableLayoutPanel1);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = System.Drawing.Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value);
            int row = tableLayoutPanel1.GetRow(button);
            int column = tableLayoutPanel1.GetColumn(button);
            //Console.WriteLine("[" + row.ToString() + "," + column.ToString() + "," + metroTrackBar1.Value + "," + metroTrackBar3.Value + "," + metroTrackBar3.Value + "]"); 
        }

        private void timerbtn_Tick(object sender, EventArgs e)
        {
            btnColor.BackColor = System.Drawing.Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value);
        }

        private void LED_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel1.Text = metroTrackBar1.Value.ToString();
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel2.Text = metroTrackBar2.Value.ToString();
        }

        private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel3.Text = metroTrackBar3.Value.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            List<ColorPoint> points = new List<ColorPoint>();
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button)
                {
                    int row = tableLayoutPanel1.GetRow(c);
                    int column = tableLayoutPanel1.GetColumn(c);
                    System.Drawing.Color buttonColor = c.BackColor;
                    points.Add(new ColorPoint { x = column, y = row, r = buttonColor.R, g = buttonColor.G, b = buttonColor.B });
                }
            }
            string json = JsonConvert.SerializeObject(points);
            var json_to_send = new StringContent(json, Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(50) })
            {
                try
                {
                    var Task = httpClient.PutAsync("http://" + SharedVariables.ShowIP() + ":" + SharedVariables.ShowPort() + "/put_led", json_to_send);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
    }
}
