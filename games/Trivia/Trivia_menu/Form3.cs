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

namespace Trivia_menu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\Ficha 2\bin\Debug\Ficha 2.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\Ficha 3 v2\bin\Debug\Ficha 3 v2.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\Ficha 4\bin\Debug\Ficha 4.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(@"E:\PSI\Módulo 9\projeto\project_principal\games\Trivia\Trivia_menu\Ficha 5\bin\Debug\Ficha 5.exe");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
