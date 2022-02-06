using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_casino
{
    public partial class horse_game : Form
    {
        public horse_game()
        {
            InitializeComponent();
            button2.Visible = false;
            label7.Visible = false;
        }
        int esqcavalo1, esqcavalo2, esqcavalo3; //Atrubuição de variáveis 
        private void horse_game_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            label7.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; //O timer inicia ao clicar no botão da partida
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox[] cavalos = {pictureBox1, pictureBox2, pictureBox3 }; //Utilização de um array 
            
            int partida = label4.Left; 

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "O Cavalo nº1 encontra-se em primeiro"; //Se o cavalo nº1 estiver em primeiro manda essa mensagem
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "O Cavalo nº2 situa-se na liderança"; //Se o cavalo nº2 estiver em primeiro manda essa mensagem
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "O Cavalo nº3 está à frente"; //Se o cavalo nº3 estiver em primeiro manda essa mensagem
            }

            foreach (var image in cavalos)
            {
                image.Left = image.Left + rnd.Next(1, 15); //Atribuição da velocidade dos Cavalos
            }
                
            for(int i = 0; i < cavalos.Length; i++)
            {
                PictureBox imagem = cavalos[i];
                int largura = imagem.Width;

                if(largura + imagem.Left >= partida)
                {
                    timer1.Enabled = false; //O timer para
                    label6.Text = "O Cavalo nº" + (i + 1) + " venceu!"; //Mensagem de qual cavalo que vence
                    button2.Visible = true;
                    label7.Visible = true;
                    return; //Para o loop
                }
                
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu voltar = new menu();
            this.Hide();
            voltar.Show();
        }

        Random rnd = new Random(); // Atruibuição de uma variável aleatória

        private void Form1_load(object sender, EventArgs e)
        {
            esqcavalo1 = pictureBox1.Left;
            esqcavalo2 = pictureBox2.Left;
            esqcavalo3 = pictureBox3.Left;

        }
    }
}
