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


namespace SpaceInvadersPSI
{   

    public partial class Form1 : Form
    {
        bool goleft;

        bool goright;

        int speed = 5;

        int score = 0;

        bool isPressed;

        int totalEnemies = 13;

        int playerSpeed = 6;

        
        public Form1()
        {
            InitializeComponent();

        }

        private void GameTimer(object sender, EventArgs e)
        {
            if (goleft)
            {   
                if(Player.Location.X < -100)
                {
                    Player.Left = +650;
                }
                else { Player.Left -= playerSpeed; }
               
            }
            else if (goright)
            {
                if (Player.Location.X > 700)
                {
                    Player.Left = -50;
                }
                else { Player.Left += playerSpeed; }
            }
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "invader")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(Player.Bounds))
                    {
                        gameOver();

                    }

                          ((PictureBox)x).Left += speed;

                    if (((PictureBox)x).Left > 720)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 10;

                        ((PictureBox)x).Left = -50;
                    }
                }
            }
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag == "bullet")
                {

                    y.Top -= 20;

                    if (((PictureBox)y).Top < this.Height - 490)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "invader")
                    {
                        if (j is PictureBox && j.Tag == "bullet")
                        {

                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                this.Controls.Remove(i);
                                this.Controls.Remove(j);
                            }
                        }
                    }
                }
            }
            label1.Text = "Score: " + score;
            if (score >= totalEnemies - 1)
            {
                timer1.Stop();
                DialogResult dialogResult = MessageBox.Show("GANHASTE, PARABENS");
                this.Hide();
                Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\project_principal\bin\Debug\project_principal.exe");

            }

        }

        private void isKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;

                Bullet();
            }
        }
    

        private void isKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {

                goright = false;
            }
            if (isPressed)
            {
                isPressed = false;
            }
        }

        private void Bullet()
        {
            PictureBox bullet = new PictureBox();

            bullet.Image = Properties.Resources.bullet;

            bullet.Size = new Size(10, 30);

            bullet.Tag = "bullet";

            bullet.SizeMode = PictureBoxSizeMode.StretchImage;

            bullet.Left = Player.Left + Player.Width / 2;

            bullet.Top = Player.Top - 20;

            this.Controls.Add(bullet);

            bullet.BringToFront();

        }
        private void gameOver()
        {
            timer1.Stop();
            label1.Text += " Game Over";
        }
    }
}
