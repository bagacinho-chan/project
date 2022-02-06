using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecionar Fotos";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Images (*.BPM;*.JPG;*.GIF;*.PNG;*.TIFF) | *.BPM;*.JPG;*.GIF;*.PNG;*.TIFF;|" + "All files (*.*) |*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            textBox1.Enabled = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer meuPlayer = new System.Media.SoundPlayer("tada.wav");
            meuPlayer.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"06-jessie_j-rainbow.mp3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"The Pink Panther Show Episode 18 - The Pink Blueprint.avi";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
