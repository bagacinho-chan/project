using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaToupeira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Jogo da Toupeira"; // Definição do Título
            this.CenterToScreen(); //O formulário fica centrado
            this.ControlBox = false; //Minizar, Aumentar ou Fechar - Desativados
            MessageBox.Show("Tem 30 segundos para acertar o máximo possível! Quando estiver preparado(a) clique em Ok", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer2.Start();
        }
        Random rnd = new Random(); //Atribuição de uma variável do tipo random

        int pontos = 0; //Atribuição de variáveis do tipo inteiro
        int jogT = 0;
        int jogF = 0;
        int tempo;
        
        void som() 
        {
            System.Media.SoundPlayer comecar = new System.Media.SoundPlayer(@"D:\Disciplinas Informáticas\PSI\11º Ano\Módulo 9\Projeto\Projeto_psi\JogodaToupeira\ponto.wav"); //Uso do MediaPlayer, caso o utilizador acerta na toupeira aparece um som
            comecar.Play();
        }

        void click_certos() //Contador que acumula os pontos e o total de jogadas caso o utilizador acerte na toupeira
        {
            pontos++;
            label1.Text = "Pontos = " + pontos;
            jogT++;
            label3.Text = "Total de Jogadas = " + jogT;

            som(); //Chama a função
        }
        void click_falhados() //Contador que acumula o total de jogadas e o total de jogadas falhadas
        {
            jogF++;
            label2.Text = "Jogadas Falhadas = " + jogF;
            jogT++;
            label3.Text = "Total de Jogadas = " + jogT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Desliga o programa
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = rnd.Next(100, 700); //Definição do eixo do x da picturebox2
            y = rnd.Next(350, 400); //Definição do eixo do y da picturebox2
            pictureBox2.Location = new Point(x, y); //Aplica uma localização da pictureBox2
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            click_certos(); //Chama o contador
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click_falhados(); //Chama o contador
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tempo++;
            label5.Text = tempo.ToString(); //Converte uma variável de tipo inteiro para string

            if (tempo == 30)
            {
                label5.Text = "Esgotado";
                timer2.Stop(); //O timer1 para
                timer1.Stop(); //O timer2 para
                MessageBox.Show("O tempo acabou!\nObtiveste uma pontuação de: " + pontos, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //Aparece uma messageBox a dizer a pontuação e que o tempo acabou e ao clicar em "ok" o programa fecha
                this.Hide();
                Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\project_principal\bin\Debug\project_principal.exe");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
