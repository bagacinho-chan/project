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

namespace QuizDeFilmes
{
    public partial class Form1 : Form
    {
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

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {

                percentage = (int)Math.Round((double)(score * 100 ) / totalQuestions);

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
                    lblQuestion.Text = "Qual foi o orçamento do filme?";

                    button1.Text = "190 milhões";
                    button2.Text = "211 milhões";
                    button3.Text = "30 milhões";
                    button4.Text = "186 milhões";
                    correctAnswer = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.img2;

                    lblQuestion.Text = "Fred Weasley perdeu qual orelha?";

                    button1.Text = "A orelha esquerda";
                    button2.Text = "A orelha direita ";
                    button3.Text = "Jorge quem perdeu a orelha";
                    button4.Text = "Nenhuma das alternativas anteriores";
                    correctAnswer = 3;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.img3;

                    lblQuestion.Text = "Quando Estreou Star Wars 5?";

                    button1.Text = "19 de abril de 1496";
                    button2.Text = "21 de janeiro de 2002";
                    button3.Text = "04 de setembro de 1997";
                    button4.Text = "19 de dezembro de 1980";
                    correctAnswer = 3;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.img4;
                    lblQuestion.Text = "Quantos filhos tem o Shrek?";

                    button1.Text = "2 Filhos";
                    button2.Text = "4 Filhos";
                    button3.Text = "Shrek não tem filhos";
                    button4.Text = "3 Filhos";
                    correctAnswer = 4;
                    break;


                case 5:
                    pictureBox1.Image = Properties.Resources.img5;
                    lblQuestion.Text = "Quem é o vilão da história?";

                    button1.Text = "Scar";
                    button2.Text = "Mufasa";
                    button3.Text = "Pumba";
                    button4.Text = "Simba";
                    correctAnswer = 1;
                    break;


                case 6:
                    pictureBox1.Image = Properties.Resources.img6;
                    lblQuestion.Text = "Que item Luke dá a Percy antes de sua primeira missão?";

                    button1.Text = "Espada ";
                    button2.Text = "Ténis voadores";
                    button3.Text = "Escudo";
                    button4.Text = "O raio mestre";
                    correctAnswer = 2;
                    break;


                case 7:
                    pictureBox1.Image = Properties.Resources.img7;
                    lblQuestion.Text = "O Filme é baseado em qual conto infantil?";

                    button1.Text = "João e o pé de feijão ";
                    button2.Text = "Branca de neve";
                    button3.Text = "A bela e a fera";
                    button4.Text = "joão e Maria";
                    correctAnswer = 4;
                    break;


                case 8:
                    pictureBox1.Image = Properties.Resources.img8;
                    lblQuestion.Text = "Qual o nome do ator que interpretou o homem de ferro/Tony Stark?";

                    button1.Text = "Robert John Downey Jr";
                    button2.Text = "Justin Bieber";
                    button3.Text = "Tumé Fernandes ";
                    button4.Text = "Rubem Mendes";
                    correctAnswer = 1;
                    break;


                case 9:
                    pictureBox1.Image = Properties.Resources.img9;
                    lblQuestion.Text = "Porque Peter Foi até o Doutor estranho?";

                    button1.Text = "Para ele fazer um feitiço pra que todo mundo esqueça quem ele é";
                    button2.Text = "Para fazer um feitiço pra que todo mundo esqueça que ele é o homem aranha";
                    button3.Text = "Para voltar no tempo e impedir Mistério de revelar a identidade dele";
                    button4.Text = "Para fazer uma poção de amor";
                    correctAnswer = 2;
                    break;


                case 10:
                    pictureBox1.Image = Properties.Resources.img10;
                    lblQuestion.Text = "Qual foi o orçamento do filme?";

                    button1.Text = "316 milhões";
                    button2.Text = "543 milões";
                    button3.Text = "5 milhões";
                    button4.Text = "446 milhões";
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
