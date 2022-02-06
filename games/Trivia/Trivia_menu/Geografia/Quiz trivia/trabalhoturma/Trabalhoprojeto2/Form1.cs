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

        int rc; //variavel resposta correta
        int questaoN = 1;    //variavel questão
        int recor;         //variavel recorde
        int p;           //variavel pontos
        int tq;    //variavel total das questão



        public Form1()
        {
            InitializeComponent();

            askQuestion(questaoN);

            tq = 10;  //Total de questões que são 10
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag); // converção para Int32

            if(buttonTag == rc)  
            {
                recor++;
            }

            if (questaoN == tq)
            {
                // vai trabalhar com precentagem

                p = (int)Math.Round((double)(recor * 500) / tq);


                MessageBox.Show( //messageBox que apresenta os resultados
                   "FIM DO QUIZ" + Environment.NewLine +  
                   "Você tem " + recor + " questões corretas." + Environment.NewLine + 
                   "Pontuação total: " + p + " Pontos" + Environment.NewLine +
                   "Percione OK para recomeçar"



   
                    );


                recor = 0;  
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
                    pictureBox1.Image = Properties.Resources.Afirica; // Apresentação da primeira imagem

                    lblQuestion.Text = "Quantos países tem África ao todo?"; // Apresentação da pergunta 
                    button1.Text = "50"; // Apresentação das opções
                    button2.Text = "60"; 
                    button3.Text = "54";
                    button4.Text = "47";

                    rc = 3; // Local da resposta ,no caso o botão é o terceiro


                    break;  // Apresentação do break 


                case 2:  //Apresentação do 2ªcase 
                    pictureBox1.Image = Properties.Resources.franca;

                    lblQuestion.Text = "Quantos países tem ao todo a Europa?";
                    button1.Text = "56";
                    button2.Text = "49";
                    button3.Text = "47";
                    button4.Text = "50";

                    rc = 4;


                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.america;

                    lblQuestion.Text = "Quantos países tem ao todo na América?";
                    button1.Text = "36";
                    button2.Text = "40";
                    button3.Text = "30";
                    button4.Text = "45";

                    rc = 1;


                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.canguro;

                    lblQuestion.Text = "De que país provem este animal?";
                    button1.Text = "Austrália";
                    button2.Text = "México";
                    button3.Text = "EUA";
                    button4.Text = "Canadá";

                    rc = 1;


                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Paises_do_Mundo_Bandeiras;

                    lblQuestion.Text = "Qual é o maior país do mundo?";
                    button1.Text = "Arábia";
                    button2.Text = "Rússia";
                    button3.Text = "Japão";
                    button4.Text = "China";

                    rc = 2;


                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.japao_og;

                    lblQuestion.Text = "Quantos países tem ao todo a Ásia?";
                    button1.Text = "45";
                    button2.Text = "53";
                    button3.Text = "50";
                    button4.Text = "49";

                    rc = 3;


                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Mapamundi;

                    lblQuestion.Text = "Quantos países tem ao todo o mundo?";
                    button1.Text = "195";
                    button2.Text = "187";
                    button3.Text = "190";
                    button4.Text = "180";

                    rc = 1;


                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.oce;

                    lblQuestion.Text = "Quantas ilhas tem ao todo na Oceânea?";
                    button1.Text = "10 mil";
                    button2.Text = "11 mil";
                    button3.Text = "12 mil";
                    button4.Text = "13 mil";

                    rc = 1;


                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.Portugal;

                    lblQuestion.Text = "Quantos metros quadrados tem Portugal?";
                    button1.Text = "91 624 km(q)";
                    button2.Text = "96 253 km(q)";
                    button3.Text = "92 212 km(q)";
                    button4.Text = "89 564 km(q)";

                    rc = 3;


                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.vs;

                    lblQuestion.Text = "Qual o melhor país?";
                    button1.Text = "Portugal";
                    button2.Text = "Japão";
                    button3.Text = "Rússia";
                    button4.Text = "Arábia";

                    rc = 1;


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
