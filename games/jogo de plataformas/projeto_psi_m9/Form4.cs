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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Niveis";
            this.BackgroundImage = Image.FromFile("background-menu.jpg");
            this.ControlBox = false;
            
            button1.Text = "NIVEL 1";
            button2.Text = "NIVEL 2";
            button3.Text = "NIVEL 3";

            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"platform\bin\Debug\platform.exe");

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nivel2 = new Form3();
            nivel2.Show();

            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"platform2\bin\Debug\platform2.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
