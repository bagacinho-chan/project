using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_3_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alunos Carlos = new alunos();

            float notaA = float.Parse(textBox8.Text);
            float notaB = float.Parse(textBox7.Text);

            textBox6.Text = Convert.ToString(Carlos.CalculoNotaFinal(notaA, notaB));

            float final = float.Parse(textBox6.Text);

            if (final >= 10)
            {
                textBox5.ForeColor = Color.Aqua;
                textBox5.BackColor = Color.Black;
                textBox5.Text = "Aprovado";
            }
            else
            {
                textBox5.ForeColor = Color.Plum;
                textBox5.BackColor = Color.Purple;
                textBox5.Text = "Reprovado";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alunos Lurdes = new alunos();

            float notaA = float.Parse(textBox12.Text);
            float notaB = float.Parse(textBox11.Text);

            textBox10.Text = Convert.ToString(Lurdes.CalculoNotaFinal(notaA, notaB));

            float final = float.Parse(textBox10.Text);

            if (final >= 10)
            {
                textBox9.ForeColor = Color.Aqua;
                textBox9.BackColor = Color.Black;
                textBox9.Text = "Aprovado";
            }
            else
            {
                textBox9.ForeColor = Color.Plum;
                textBox9.BackColor = Color.Purple;
                textBox9.Text = "Reprovado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alunos Exemplo = new alunos();

            float notaA = float.Parse(textBox1.Text);
            float notaB = float.Parse(textBox2.Text);

            textBox3.Text = Convert.ToString(Exemplo.CalculoNotaFinal(notaA, notaB));

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
    }
}
