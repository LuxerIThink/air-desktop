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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            led2.Hide();
            tabela1.Hide();
            wykresy2.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnwykresy_Click(object sender, EventArgs e)
        {
            wykresy2.Show();
            led2.Hide();
            tabela1.Hide();
            ip2.Hide();

        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            tabela1.Show();
            wykresy2.Hide();
            led2.Hide();
            ip2.Hide();
        }

        private void btnLED_Click(object sender, EventArgs e)
        {
            led2.Show();
            wykresy2.Hide();
            tabela1.Hide();
            ip2.Hide();
        }
        private void btnIP_Click(object sender, EventArgs e)
        {
            ip2.Show();
            led2.Hide();
            wykresy2.Hide();
            tabela1.Hide();
        }

        private void wykresy1_Load(object sender, EventArgs e)
        {

        }

        private void wykresy2_Load(object sender, EventArgs e)
        {

        }
    }
}
