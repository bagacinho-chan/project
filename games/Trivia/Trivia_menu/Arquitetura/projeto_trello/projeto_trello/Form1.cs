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

namespace projeto_trello
{
    public partial class Form1 : Form
    {

        //criação das variaveis

        int questao_correta;
        int numero_questao = 1;
        int pontos;
        int tt_pontos;
        int total_questions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(numero_questao);

            total_questions = 10;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Arquitetura de Computadores";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"C:\Users\Kev 152\Desktop\Escola\.PSI\11º\Modulo 9\Projeto\Trivia_menu\bin\Debug\Trivia_menu.exe");
        }

        
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag== questao_correta)
            {
                pontos++;

            }

            if(numero_questao==total_questions)
            {
                tt_pontos = (int)Math.Round((double)(pontos * 500) / total_questions);
                MessageBox.Show("Fim do Quiz de Arquitetura de computadores! " + Environment
                    .NewLine + "Voce acertou "  + pontos +  " questões. "
                    + Environment.NewLine + "Seus pontos é de " + tt_pontos + " clique em OK para recomeçar."
                    
                    );

                pontos = 0;
                numero_questao = 0;
                askQuestion(numero_questao);

            }
            numero_questao++;
            askQuestion(numero_questao);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    
                    lblQuestion.Text = "Principal Característica dos computadores de Primeira Geração(1946-1954)?";
                    button1.Text = "A - Circuito Integrado";
                    button2.Text = "B - Válvula";
                    button3.Text = "C - Lasca";
                    button4.Text = "D - Transisto";

                    questao_correta = 2;

                        break;

                case 2:

                    lblQuestion.Text = "Qual foi o primeiro processador da Intel?";
                    button1.Text = "A - Intel 4004";
                    button2.Text = "B - Intel 8008";
                    button3.Text = "C - Intel 8080";
                    button4.Text = "D - Intel 286";

                    questao_correta = 1;

                    break;

                case 3:
                    lblQuestion.Text = "Principal Característica dos computadores de Segunda Geração (1955-1964)?";
                    button1.Text = "A - Circuito Integrado";
                    button2.Text = "B - Válvula";
                    button3.Text = "C - Lasca";
                    button4.Text = "D - Transisto";

                    questao_correta = 4;

                    break;

                case 4:
                    lblQuestion.Text = "Quem foi considerado o pai da computação?";
                    button1.Text = "A - Gartner";
                    button2.Text = "B - Alan Touring";
                    button3.Text = "C - Eniac";
                    button4.Text = "D - Von Neumann";

                    questao_correta = 2;

                    break;

                case 5:
                    lblQuestion.Text = "A grande maioria dos computadores atualmente segue um modelo proposto pelo:";
                    button1.Text = "A - Charles Babbage";
                    button2.Text = "B - Von Neumann";
                    button3.Text = "C - Sthephen Wozniak";
                    button4.Text = "D - Steve Jobs";

                    questao_correta = 2;

                    break;

                case 6:
                    lblQuestion.Text = "O que é Software?";
                    button1.Text = "A - É a parte física de um computador";
                    button2.Text = "B - É um jogo";
                    button3.Text = "C - O software é programa rodado em um computador,executando suas funções";
                    button4.Text = "D - Nenhuma das anteriores está correta";

                    questao_correta = 3;

                    break;

                case 7:
                    lblQuestion.Text = "Qual é a função básica do Processador?";
                    button1.Text = "A - Deixa o PC mais rápido";
                    button2.Text = "B - Transformar dados em informação";
                    button3.Text = "C - Se comunicar com o restante dos componentes";
                    button4.Text = "D - Fazer o PC dar vídeo";

                    questao_correta = 2;

                    break;

                case 8:
                    lblQuestion.Text = "Atributos que se referem á arquitetura de um computador:";
                    button1.Text = "A - Mecanismo de entrada e saída";
                    button2.Text = "B - Detalhes de hardware e tecnologia de memória utilizada";
                    button3.Text = "C - Memórias e periféricos";
                    button4.Text = "D - Conjunto de instruções e detalhes de hardware";

                    questao_correta = 1;

                    break;

                case 9:
                    lblQuestion.Text = "O que são componentes básicos de um sistema computacional?";
                    button1.Text = "A - Processador e memória ";
                    button2.Text = "B - Memória, sistema operacional e dispositivo de entrada";
                    button3.Text = "C - Teclado e mouse";
                    button4.Text = "D - CPU, dispositivos de entrada e saída de memória e barramento";

                    questao_correta = 4;

                    break;

                case 10:
                    lblQuestion.Text = "O que é memória principal? ";
                    button1.Text = "A - É onde os processos e seus dados são armazenados para serem processados ​​pela CPU";
                    button2.Text = "B - É uma memória que procura dados enquanto o processador lê outros dados";
                    button3.Text = "C - É onde os arquivos e dados são armazenados";
                    button4.Text = "D - Nenhuma das opções está correta";

                    questao_correta = 1;

                    break;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\bin\Debug\Trivia_menu.exe");
        }
    }
}
