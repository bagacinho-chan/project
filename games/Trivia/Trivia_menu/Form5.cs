using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_menu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alunos Carlos = new alunos();
            float notaA = float.Parse(textBox1.Text);
            float notaB = float.Parse(textBox2.Text);

            textBox3.Text = Convert.ToString(Carlos.CalculaNotaFinal(notaA, notaB));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float final = float.Parse(textBox3.Text);

            if (final >= 10)
            {
                textBox4.ForeColor = Color.Aqua;
                textBox4.BackColor = Color.Black;
                textBox4.Text = "Aprovado";
            }
            else
            {
                textBox4.ForeColor = Color.Plum;
                textBox4.BackColor = Color.Purple;
                textBox4.Text = "Reprovado";
            }
        }
        //____________________________________________________________________________

        private void button2_Click(object sender, EventArgs e)
        {
            alunos Lurdes = new alunos();
            float notaA = float.Parse(textBox5.Text);
            float notaB = float.Parse(textBox6.Text);

            textBox7.Text = Convert.ToString(Lurdes.CalculaNotaFinal(notaA, notaB));
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            float final = float.Parse(textBox7.Text);

            if (final >= 10)
            {
                textBox8.ForeColor = Color.Aqua;
                textBox8.BackColor = Color.Black;
                textBox8.Text = "Aprovado";
            }
            else
            {
                textBox8.ForeColor = Color.Plum;
                textBox8.BackColor = Color.Purple;
                textBox8.Text = "Reprovado";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
