using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace projeto_psi_m9
{
    public partial class Form1 : Form
    {

        Form2 ajuda = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Menu";
            this.ControlBox = false;
            this.BackgroundImage = Image.FromFile("background-menu.jpg");

            button1.Text = "Jogar";
            button2.Text = "Voltar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 niveis = new Form4();
            niveis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\project_principal\bin\Debug\project_principal.exe");
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajuda.ShowDialog();
        }
    }
}
