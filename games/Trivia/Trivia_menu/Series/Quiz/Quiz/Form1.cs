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

namespace Quiz
{
    public partial class Form1 : Form
    {
        //variaveis
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;



        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void chekAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if( buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {


                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Fim do Quiz!" + Environment.NewLine +
                    "Você teve " + score + " Questões corretas." + Environment.NewLine +
                    "Sua porcentagem total foi de " + percentage + "%" + Environment.NewLine +
                    "Clique para jogar novamente"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.img1;
                    
                    lblQuestion.Text = "Em qual episodio a xerife peterkin morreu?";
            
                    button1.Text = "Temporada 1 Episódio 2";
                    button2.Text = "Temporada 1 Episódio 8";
                    button3.Text = "Temporada 3 Episódio 5";
                    button4.Text = "Temporada 2 Episódio 8";

                    correctAnswer = 2;

                    break;


                case 2:
                    pictureBox1.Image = Properties.Resources.img2;
                    
                    lblQuestion.Text = "Com Quem O Samuel Tem Um Caso Na 2ª Temporada?";
            
                    button1.Text = "Rebeca";
                    button2.Text = "Ari";
                    button3.Text = "Marina";
                    button4.Text = "Carla";

                    correctAnswer = 4;

                    break;


                case 3:
                    pictureBox1.Image = Properties.Resources.img3;
                    
                    lblQuestion.Text = "Quantos anos a Millie Bobby Brown tinha quando fez a primeira temporada?";
            
                    button1.Text = "10 anos";
                    button2.Text = "07 anos";
                    button3.Text = "13 anos";
                    button4.Text = "15 anos";

                    correctAnswer = 3;

                    break;


                 case 4:
                    pictureBox1.Image = Properties.Resources.img4;
                    
                    lblQuestion.Text = "Como eles Fogem da casa da moeda?";
            
                    button1.Text = "pela tubulação do esgoto";
                    button2.Text = "Por um Túneo abaixo do cofre";
                    button3.Text = "Escondidos em um caminhão";
                    button4.Text = "Em um helicóptero";

                    correctAnswer = 2;

                    break;


                case 5:
                    pictureBox1.Image = Properties.Resources.img5;
                    
                    lblQuestion.Text = "Que droga Walt vende para sustentar sua familia?";
            
                    button1.Text = "Metanfetamina";
                    button2.Text = "Cocaína";
                    button3.Text = "MDMA";
                    button4.Text = "Heroína";

                    correctAnswer = 1;

                    break;


                case 6:
                    pictureBox1.Image = Properties.Resources.img6;
                    
                    lblQuestion.Text = "Qual o nome da égua de Geralt?";
            
                    button1.Text = "Plotka";
                    button2.Text = "Ploka";
                    button3.Text = "Plotika";
                    button4.Text = "Renfri";

                    correctAnswer = 1;

                    break;


                case 7:
                    pictureBox1.Image = Properties.Resources.img7;
                    
                    lblQuestion.Text = "Quantas temporadas tem a serie?";
            
                    button1.Text = "3 Temporadas ";
                    button2.Text = "8 Temporadas";
                    button3.Text = "6 Temporadas";
                    button4.Text = "4 Tmporadas";

                    correctAnswer = 3;

                    break;


                case 8:
                    pictureBox1.Image = Properties.Resources.img8;
                    
                    lblQuestion.Text = "De acordo com a ordem cronológica, qual foi o primeiro zumbi que Rick matou?";
            
                    button1.Text = "Hannah, a zumbi da bicicleta";
                    button2.Text = "Summer, a zumbi do ursinho";
                    button3.Text = "Leon, o zumbi da delegacia ";
                    button4.Text = "O zumbi que estava encostado na cerca em frente a casa do Morgan";

                    correctAnswer = 4;

                    break;


                case 9:
                    pictureBox1.Image = Properties.Resources.img9;
                    
                    lblQuestion.Text = "Quem era Floki?";
            
                    button1.Text = "Construtor de casas e melhor amigo de Ragnar";
                    button2.Text = "Construtor de barcos e o melhor amigo de Ragnar";
                    button3.Text = "Construtor de barcos e inimigo de Ragnar";
                    button4.Text = "Construtor de barcos e melhor amigo de Rollo";

                    correctAnswer = 2;

                    break;


                case 10:
                    pictureBox1.Image = Properties.Resources.img10;
                    
                    lblQuestion.Text = "Com quantos anos o Cinco/Five saiu de casa?";
            
                    button1.Text = "13 Anos";
                    button2.Text = "15 Anos";
                    button3.Text = "16 Anos";
                    button4.Text = "11 Anos";

                    correctAnswer = 1;

                    break;



            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\bin\Debug\Trivia_menu.exe");
        }
    }
}
