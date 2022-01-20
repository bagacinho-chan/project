using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_principal
{
    public partial class Resgatar_recompensas : Form
    {
        public Resgatar_recompensas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            this.Close();
            voltar.Show();
        }
    }
}
