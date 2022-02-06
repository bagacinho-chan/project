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
using System.IO;

namespace Trivia_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2(); //criação de um novo form
            this.Hide();    //esconde o form correntemente aberto
            f2.ShowDialog();    //mostra o form2
            this.Show();    //volta a mostrar o form1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\project_principal\bin\Debug\project_principal.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();   //butao fechar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\Arquitetura\projeto_trello\projeto_trello\bin\Debugprojeto_trello.exe"); //abre o projeto da pasta selecionada
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   //butao minimizar
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\Series\Quiz\Quiz\bin\DebugQuiz.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\trivia_Programação\Código\bin\Debug\netcoreapp3.1Trabalhoprojeto2.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\ConhecimentoGeral\trabalhoturma\Trabalhoprojeto2\bin\Debug\netcoreapp3.1\Trabalhoprojeto2.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\Filmes\QuizDeFilmes\QuizDeFilmes\bin\Debug\QuizDeFilmes.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\Geografia\Quiz trivia\trabalhoturma\Trabalhoprojeto2\bin\Debug\netcoreapp3.1\Trabalhoprojeto2.exe");
        }
    }
}
