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
using System.Xml.Linq;
using static SharedVariables;

namespace WindowsFormsApp
{
    public partial class tabela : UserControl
    {
        public tabela()
        {
            InitializeComponent();
            timer.Start();
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
                var result = await httpClient.GetAsync("http://" + SharedVariables.ShowIP() + ":" + SharedVariables.ShowPort() + "/get_data");
                var json = await result.Content.ReadAsStringAsync();
                dynamic jsonObject = JsonConvert.DeserializeObject(json);
                dynamic arrayElement = jsonObject[0];

                foreach (var item in arrayElement)
                {
                    dataGridView1.Columns.Add(item.Name.ToString(), item.Name.ToString());
                }

                dataGridView1.Rows.Add();
                int currentRow = dataGridView1.Rows.Count-2;
                int currentColumn = 0;

                foreach (var item in arrayElement)
                {
                    var name = arrayElement[item.Name];
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
    }
}
