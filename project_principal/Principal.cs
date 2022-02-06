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

namespace project_principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resgatar_recompensas resgatar = new Resgatar_recompensas();
            this.Hide();
            resgatar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            casino casino = new casino();
            this.Hide();
            casino.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Space Invaders\SpaceInvadersPSI\bin\Debug\netcoreapp3.1\SpaceInvadersPSI.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\bin\Debug\Trivia_menu.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\jogo de plataformas\projeto_psi_m9\bin\Debug\projeto_psi_m9");
        }
    }
}
