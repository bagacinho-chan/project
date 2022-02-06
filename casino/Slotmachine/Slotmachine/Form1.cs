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

namespace Slotmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random aleatorio = new Random(); // Criação de um random
        int a, b, c, mover,wins,pontostotal,perda; //criação de variaveis
        void resultadogame() //criação da funcao. para depois chamar
        {
            if (System.Convert.ToInt32(a & b) != c) 
            {
                wins++;
                labelwin.Text = "Gannhos:" + wins;
                
                pontostotal += 2;
                pontos.Text = "Pontos: $" + Convert.ToInt32(numericUpDown1.Value) * pontostotal;
                botaojogar.Text = "Continuar";
                casinoslot.Text = "Ganhaste!!!";
                botaoaposta.Enabled = true;

            }
            else
            {
                casinoslot.Text = "Perdeste ;-;";
                perda++;
                labelloss.Text = "Pontos:  "+perda; //aumentas o numero de perdas
                pontos.Text = "Pontos: $ 0"; 
                pontostotal = 0;
                numericUpDown1.Text = "0";
                botaojogar.Enabled = false;
                pictureBox1.Image = Properties.Resources.fumo2; 
                pictureBox2.Image = Properties.Resources.fumo2;
                pictureBox3.Image = Properties.Resources.fumo2;
                botaoaposta.Enabled = true; // botao de apostar aparece
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botaoaposta_Click(object sender, EventArgs e)
        {
            casinoslot.Text = "Casino";    //Texto a apresentar o casino
            pontostotal = 0; //valor de pontos
            numericUpDown1.Enabled = true; //numericupdown aparece tambem
            numericUpDown1.Text = "0"; //numericup down = 0
            numericUpDown1.BackColor = Color.White; //Cor
            numericUpDown1.Focus();   //Focar no numericupdown
            botaojogar.Enabled = true; //botao jogar ficar disponivel para apostar
            botaojogar.Text = "Apostar"; // um simples botao com texto
            pontos.Text = "Pontos";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            this.Hide();
            form1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\project_principal\bin\Debug\project_principal.exe");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text=="") //Se nao tiver algum valor inserido recusa-se a apostar
            {
                MessageBox.Show("Por favor clique no botão de jogar e coloque um valor de aposta");
            }
            else//se aceitar o valor...
            {
                botaoaposta.Enabled = false; //botao de aposta desativa-se enquanto tiver a "rolar"
                timer1.Enabled = true; //timer 
                casinoslot.Text = "Casino"; //texto basico
                numericUpDown1.Enabled = false; //Numericupdown desativa enquanto esta a "rolar"
                numericUpDown1.BackColor = Color.Black;; //Cor do background (do numericupdown)
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mover++;
            if (mover < 30) //randoms
            {
                a = aleatorio.Next(5);
                b = aleatorio.Next(5);
                c = aleatorio.Next(5);
                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.dima;

                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources._7;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.fumo2;
                        break;
                }
                switch (b)
                {

                    case 1:
                        pictureBox2.Image = Properties.Resources.dima;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources._7;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.fumo2;
                        break;
                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.dima;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources._7;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.fumo2;
                        break;
                }
            }
            else
            {
                timer1.Enabled = false; //deastiva timer
                mover = 0; //nao da "roll"
                resultadogame(); //chamar a funcao
            }
        }
    }
}
