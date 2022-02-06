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
using System.IO;

namespace Ficha_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selecao1, selecao2;

            textBox1.Focus();

            selecao1 = Int32.Parse(Interaction.InputBox("Digite a posição do 1º caracter", "Inicio seleção", "1"));
            selecao2 = Int32.Parse(Interaction.InputBox("Digite quantos caracteres a selecionar", "Nº caracteres", "5"));

            textBox1.Select(selecao1, selecao2);

            string selecionado = textBox1.SelectedText;
            MessageBox.Show("O texto selecionado é: " + selecionado);

            DialogResult resposta;
            resposta = MessageBox.Show("Deseja apagar o texto selecionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Convert.ToString(resposta) == "Yes")
                textBox1.Cut();
            else
                textBox1.Copy();

            textBox2.Paste();
            Clipboard.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox2.ForeColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox2.BackColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                textBox2.Font = fontDialog1.Font;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter sw;

            saveFileDialog1.FileName = "";
            saveFileDialog1.Title = "Guardar ficheiro";
            saveFileDialog1.InitialDirectory = @"c:\";
            saveFileDialog1.Filter = "(*.TXT)|*.TXT|(*.DOC)|*.DOC";
            saveFileDialog1.ShowDialog();
            
            if (saveFileDialog1.FileName != "")
            {
                sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox2.Text);
                sw.Close();
                MessageBox.Show("Operação realizada com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
