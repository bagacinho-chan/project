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

namespace Trabalhoprojeto2
{
    public partial class Form1 : Form
    {


        //variaveis do Quiz

        int respostacorreta; //variavel resposta correta
        int questaoN = 1;    //variavel questão
        int recorde;         //variavel recorde
        int ponto;           //variavel pontos
        int totalquestao;    //variavel total das questão



        public Form1()
        {
            InitializeComponent();

            askQuestion(questaoN);

            totalquestao = 10;  //Total de questões que são 10
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag); // converção para Int32

            if(buttonTag == respostacorreta)  
            {
                recorde++;
            }

            if (questaoN == totalquestao)
            {
                // vai trabalhar com percentagem

                ponto = (int)Math.Round((double)(recorde * 500) / totalquestao);


                MessageBox.Show( //messageBox que apresenta os resultados
                   "FIM DO QUIZ" + Environment.NewLine +  
                   "Você tem " + recorde + " questões corretas." + Environment.NewLine + 
                   "Pontuação total: " + ponto + " Pontos" + Environment.NewLine +
                   "Percione OK para recomeçar"



   
                    );


                recorde = 0;  
                questaoN = 0;
                askQuestion(questaoN);


            }


            questaoN++;
            askQuestion(questaoN);



        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {

                case 1:   //Apresentação de case 
                    pictureBox1.Image = Properties.Resources.im_3; // Apresentação da primeira imagem

                    lblQuestion.Text = "Quantos fusos horários tem a Rússia?"; // Apresentação da pergunta 
                    button1.Text = "24"; // Apresentação das opções
                    button2.Text = "9"; 
                    button3.Text = "11";
                    button4.Text = "12";

                    respostacorreta = 3; // Local da resposta ,no caso o botão é o terceiro


                    break;  // Apresentação do break 


                case 2:  //Apresentação do 2ªcase 
                    pictureBox1.Image = Properties.Resources.im_4;

                    lblQuestion.Text = "Quantos dias demora a Terra a orbitar o Sol?";
                    button1.Text = "600/601";
                    button2.Text = "211/212";
                    button3.Text = "524/525";
                    button4.Text = "365/366";

                    respostacorreta = 4;


                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.im_5;

                    lblQuestion.Text = "Que país tem mais ilhas no mundo?";
                    button1.Text = "Suécia";
                    button2.Text = "Portugal";
                    button3.Text = "Angola";
                    button4.Text = "Somália";

                    respostacorreta = 1;


                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.im_6;

                    lblQuestion.Text = "Qual foi a série de livros mais vendida no século XXI?";
                    button1.Text = "Harry Potter";
                    button2.Text = "Mindset";
                    button3.Text = "O investigador Inteligente";
                    button4.Text = "O Código da Vinci";

                    respostacorreta = 1;


                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.im_7;

                    lblQuestion.Text = "Quantas teclas tem um piano clássico?";
                    button1.Text = "(121)";
                    button2.Text = "(88)";
                    button3.Text = "(254)";
                    button4.Text = "(73)";

                    respostacorreta = 2;


                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.im_8;

                    lblQuestion.Text = "Onde é que foram realizados os primeiros Jogos Olímpicos modernos?";
                    button1.Text = "Uruguai,1962";
                    button2.Text = "Italia,2004";
                    button3.Text = "Athenas, 1896";
                    button4.Text = "letônia,1768";

                    respostacorreta = 3;


                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.im_9;

                    lblQuestion.Text = "Quando é que a Netflix foi fundada; 1997,2001, 2009, 2015?";
                    button1.Text = "(1997)";
                    button2.Text = "(2001)";
                    button3.Text = "(2009)";
                    button4.Text = "(2015)";

                    respostacorreta = 1;


                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.im_10;

                    lblQuestion.Text = "Qual é a flor nacional do Japão?";
                    button1.Text = "Flor de cerejeira";
                    button2.Text = "Dente de leão";
                    button3.Text = "Rosa";
                    button4.Text = "Tulipa";

                    respostacorreta = 1;


                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.im_11;

                    lblQuestion.Text = "Qual é o animal nacional da Austrália?";
                    button1.Text = "Kuala";
                    button2.Text = "Leão";
                    button3.Text = "Canguru-vermelho";
                    button4.Text = "Baleia Azul";

                    respostacorreta = 3;


                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.im_12;

                    lblQuestion.Text = "Que piloto de Fórmula 1 ganhou mais campeonatos?";
                    button1.Text = "Max Verstappen";
                    button2.Text = "Nicholas Latifi";
                    button3.Text = "Cristiano Ronaldo";
                    button4.Text = "Michael Schumacher";

                    respostacorreta = 4;


                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\bin\Debug\Trivia_menu.exe");
        }
    }
}
