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


        //Definição das variaveis do Quiz

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int ponto;
        int totalQuestion;



        public Form1()
        {
            InitializeComponent();

            //Executa a função do trivia na primeira questão
            askQuestion(questionNumber);

            //Define o tatal de questões 
            totalQuestion = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            //Verifica se a resposta do utilizado está correta
            if(buttonTag == correctAnswer)
            {
                score++;
            }

            //Uma instrução if para quando chegar ao fim exibir uma MessageBox mostrando a pontuação do jogador
            if (questionNumber == totalQuestion)
            {
                
                //Calcula a pontuação do quiz levando em conta que cada questão vale 10 pontos
                ponto = (int)Math.Round((double)(score * 100) / totalQuestion);


                MessageBox.Show(
                   "FIM DO QUIZ" + Environment.NewLine + 
                   "Você tem " + score + " questões corretas." + Environment.NewLine + 
                   "Pontuação total: " + ponto + " Pontos" + Environment.NewLine +
                   "Percione OK para recomeçar"



   
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

            switch (qnum)
            {
                //pergunta 1
                case 1:
                    pictureBox1.Image = Properties.Resources._1;

                    lblQuestion.Text = "1 - A intrução if é usada para qual funçao?";
                    button1.Text = "A - Loop";
                    button2.Text = "B - Condição";
                    button3.Text = "C - Break ";
                    button4.Text = "D - Armazenamento ";

                    correctAnswer = 2;
                    break;

                //pergunta 2
                case 2:
                    pictureBox1.Image = Properties.Resources._2;

                    lblQuestion.Text = "2 - A instrução for é usada para qual função?";
                    button1.Text = "A - Loop";
                    button2.Text = "B - Condição";
                    button3.Text = "C - Break ";
                    button4.Text = "D - Armazenamento ";

                    correctAnswer = 1;
                    break;

                //pergunta 3
                case 3:
                    pictureBox1.Image = Properties.Resources._3;

                    lblQuestion.Text = "3 - O uso do símbolo ‘==’ é para representar:";
                    button1.Text = "A - Igualdade";
                    button2.Text = "B - Atribuição de valores";
                    button3.Text = "C - Soma ";
                    button4.Text = "D - Multiplicação ";

                    correctAnswer = 2;
                    break;

                //pergunta 4
                case 4:
                    pictureBox1.Image = Properties.Resources._4;

                    lblQuestion.Text = "4 - O uso do símbolo ‘!’ é para representar:";
                    button1.Text = "A - Igualdade";
                    button2.Text = "B - Atribuição de valores";
                    button3.Text = "C - Negação lógica";
                    button4.Text = "D - Multiplicação ";

                    correctAnswer = 3;
                    break;

                //pergunta 5
                case 5:
                    pictureBox1.Image = Properties.Resources._5;

                    lblQuestion.Text = "5 - A instrução case é usada para:";
                    button1.Text = "A - Igualdade";
                    button2.Text = "B - Condição";
                    button3.Text = "C - Soma ";
                    button4.Text = "D - Multiplicação ";

                    correctAnswer = 2;
                    break;

                //pergunta 6
                case 6:
                    pictureBox1.Image = Properties.Resources._6;

                    lblQuestion.Text = "6 - O uso do símbolo ‘%’ é para representar:";
                    button1.Text = "A - Igualdade";
                    button2.Text = "B - Módulo (resto da divisão)";
                    button3.Text = "C - Soma ";
                    button4.Text = "D - Multiplicação ";

                    correctAnswer = 2;
                    break;

                //pergunta 7
                case 7:
                    pictureBox1.Image = Properties.Resources._7;

                    lblQuestion.Text = "7 - O uso do símbolo ‘||’ é para representar:";
                    button1.Text = "A - Ou (Operador Lógico)";
                    button2.Text = "B - Módulo (resto da divisão)";
                    button3.Text = "C - Soma ";
                    button4.Text = "D - Multiplicação ";

                    correctAnswer = 1;
                    break;

                //pergunta 8
                case 8:
                    pictureBox1.Image = Properties.Resources._8;

                    lblQuestion.Text = "8 - O uso do símbolo ‘&&’ é para representar:";
                    button1.Text = "A - Ou (Operador Lógico)";
                    button2.Text = "B - Módulo (resto da divisão)";
                    button3.Text = "C - Soma ";
                    button4.Text = "D - And (Operador Lógico)";

                    correctAnswer = 4;
                    break;

                //pergunta 9
                case 9:
                    pictureBox1.Image = Properties.Resources._9;

                    lblQuestion.Text = "9 - Front-End é um termo usado para definir:";
                    button1.Text = "A - Programação da interface (A cara do app)";
                    button2.Text = "B - O que ocorre na parte funcional do app";
                    button3.Text = "C - É o termo usado para aplicativos caros";
                    button4.Text = "D - Back-end é quando o programa muito ruim";

                    correctAnswer = 1;
                    break;

                //pergunta 10
                case 10:
                    pictureBox1.Image = Properties.Resources._10;

                    lblQuestion.Text = "10 - Back-End é um termo usado para definir:";
                    button1.Text = "A - Programação da interface (A cara do app)";
                    button2.Text = "B - O que ocorre na parte funcional do app";
                    button3.Text = "C - É o termo usado para aplicativos caros.";
                    button4.Text = "D - Back-end é quando o programa muito ruims";

                    correctAnswer = 2;
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
