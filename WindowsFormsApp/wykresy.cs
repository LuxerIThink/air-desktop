using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;
using static SharedVariables;
using System.Windows.Media.Media3D;
using System.Threading;

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
        
        private async void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(50) };
                var result = await httpClient.GetAsync("http://" + SharedVariables.ShowIP() + ":" + SharedVariables.ShowPort() + "/get_data");
                var json = await result.Content.ReadAsStringAsync();
                dynamic jsonObject = JsonConvert.DeserializeObject(json);
                dynamic arrayElement = jsonObject[0];
                List<dynamic> valuesList = new List<dynamic>() { "temperature", "pressure", "humidity", "roll", "pitch", "yaw" };
                List<dynamic> charts = new List<dynamic>() { chart1, chart2, chart3, chart4, chart5, chart6 };

                int i = 0;

                foreach (var item in valuesList)
                {
                    var name = arrayElement[item];
                    var value = name["value"];
                    string unit = name["unit"];
                    charts[i].Series["Data"].Points.AddY(Convert.ToDouble(value));
                    charts[i].ChartAreas[0].AxisX.Title = "Samples";
                    charts[i].ChartAreas[0].AxisY.Title = unit;
                    i++;
                }


            }
            catch (Exception exc)
            {
                //Console.WriteLine(exc.Message);
            }

        }
    }
}

