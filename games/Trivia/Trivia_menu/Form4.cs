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
    public partial class Form4 : Form
    {
        public static int comprimento, altura, area; //variaveis globais
        
        class Retangulo
        {
            //metodo sem argumentos
            public int Calcular()
            {
                area = comprimento * altura;
                return area;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retangulo retangulo = new Retangulo();
            comprimento = Int32.Parse(textBox1.Text);
            altura = Int32.Parse(textBox2.Text);
            MessageBox.Show("Area: " + retangulo.Calcular());
        }
    }
}
