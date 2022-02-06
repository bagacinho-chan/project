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

namespace projeto_psi_m9
{
    public partial class Form3 : Form
    {

        bool goLeft;
        bool goRight;
        bool saltar;
        bool temChave;

        int jumpSpeed = 10;
        int force = 8;
        int pontuacao = 0;

        int velocidadeJogador = 10;
        int backgroundSpeed = 8;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Nivel 2";
        }

        private void MainGameEvent(object sender, EventArgs e)
        {
            txtPontuacao.Text = "Score: " + pontuacao;
            txtPontuacao.Left = 536;
            jogador.Top += jumpSpeed;

            if (goLeft == true && jogador.Left > 60)
            {
                jogador.Left -= velocidadeJogador;
            }
            if (goRight == true && jogador.Left + (jogador.Width + 50) < this.ClientSize.Width)
            {
                jogador.Left += velocidadeJogador;
            }


            if (goLeft == true && background.Left < 0)
            {
                background.Left += backgroundSpeed;
                MoveGameElements("forward");
            }

            if (goRight == true && background.Left > -640)
            {
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            if (saltar == true)
            {
                jumpSpeed = -10;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            if (saltar == true && force < 0)
            {
                saltar = false;
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "plataforma")
                {

                    if (jogador.Bounds.IntersectsWith(x.Bounds) && saltar == false)
                    {
                        force = 8;
                        jogador.Top = x.Top - jogador.Height;
                        jumpSpeed = 0;
                    }

                    x.BringToFront();

                }
                if (x is PictureBox && (string)x.Tag == "moeda")
                {

                    if (jogador.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        pontuacao += 1;
                    }

                }
            }

            if (jogador.Bounds.IntersectsWith(chave.Bounds))
            {
                chave.Visible = false;
                temChave = true;
            }

            if (jogador.Bounds.IntersectsWith(porta.Bounds) && temChave == true)
            {
                porta.Image = Image.FromFile("door-open.jpg");
                GameTimer.Stop();
                MessageBox.Show("Muito bem, conseguiu passar de nivel! ");
                this.Close();
            }

            if (jogador.Top + jogador.Height > this.ClientSize.Height)
            {
                GameTimer.Stop();
                MessageBox.Show("Você morreu!");
                this.Close();
                Restart();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && saltar == false)
            {
                saltar = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (saltar == true)
            {
                saltar = false;
            }
        }

        private void Restart()
        {
            Form3 nivel2 = new Form3();
            nivel2.Show();
            this.Close();
        }

        private void MoveGameElements(string direction)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "plataforma" || x is PictureBox && (string)x.Tag == "moeda" || x is PictureBox && (string)x.Tag == "chave" || x is PictureBox && (string)x.Tag == "porta")
                {

                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }

        }

    }
}
