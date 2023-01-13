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
using static SharedVariables;

namespace WindowsFormsApp
{
    public partial class tabela : UserControl
    {
        public tabela()
        {
            InitializeComponent();
            timer.Start();
            dataGridView1.Columns.Add("Temperature", "Temperature");
            dataGridView1.Columns.Add("Pressure", "Pressure");
            dataGridView1.Columns.Add("Humidity", "Humidity");
            dataGridView1.Columns.Add("Roll", "Roll");
            dataGridView1.Columns.Add("Pitch", "Pitch");
            dataGridView1.Columns.Add("Yaw", "Yaw");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabela_Load(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(50) };
                var result = await httpClient.GetAsync("http://" + SharedVariables.ShowIP() + ":" + SharedVariables.ShowPort() + "/get_data.php");
                var json = await result.Content.ReadAsStringAsync();
                dynamic jsonObject = JsonConvert.DeserializeObject(json);
                dynamic arrayElement = jsonObject[0];
                List<dynamic> valuesList = new List<dynamic>() { "temperature", "pressure", "humidity", "roll", "pitch", "yaw" };
                dataGridView1.Rows.Add();
                int currentRow = dataGridView1.Rows.Count-2;
                int currentColumn = 0;
                
                foreach (var item in valuesList)
                {
                    var name = arrayElement[item];
                    string value = name["value"];
                    string unit = name["unit"];
                    dataGridView1[currentColumn, currentRow].Value = value + " " + unit;
                    currentColumn++;
                }
                
            }
            catch (Exception exc)
            {
                //Console.WriteLine(exc.Message);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
