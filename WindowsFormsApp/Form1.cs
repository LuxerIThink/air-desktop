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
            led1.Hide();
            tabela1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnwykresy_Click(object sender, EventArgs e)
        {
            wykresy1.Show();
            led1.Hide();
            tabela1.Hide();

        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            tabela1.Show();
            wykresy1.Hide();
            led1.Hide();
        }

        private void btnLED_Click(object sender, EventArgs e)
        {
            led1.Show();
            wykresy1.Hide();
            tabela1.Hide();
        }
    }
}
