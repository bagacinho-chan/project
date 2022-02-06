using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO;

namespace Ficha_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2Collapsed = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Orientation = Orientation.Horizontal;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Orientation = Orientation.Vertical;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.BorderStyle = BorderStyle.None;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            splitContainer1.SplitterWidth = (int)(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lts, km;

            automovel carro = new automovel();

            carro.marca = Interaction.InputBox("Qual a marca?");
            textBox1.Text = carro.marca;
            carro.modelo = Interaction.InputBox("Qual o modelo?");
            textBox2.Text = carro.modelo;
            carro.cor = Interaction.InputBox("Qual a cor?");
            textBox3.Text = carro.cor;
            carro.cilindrada = Convert.ToInt32(Interaction.InputBox("Qual a cilindrada?"));
            textBox4.Text = Convert.ToString(carro.cilindrada);

            lts = Int32.Parse(Interaction.InputBox("Quantos litros?"));
            km = Int32.Parse(Interaction.InputBox("Quantos km?"));

            textBox5.Text = Convert.ToString(carro.consumo_medio(lts, km));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Process.Start(@"C:\Users\Kev 152\Desktop\Escola\.PSI\11º\Modulo 9\Projeto\Trivia_menu\bin\Debug\Trivia_menu.exe");
        }
    }
}
