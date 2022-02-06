
namespace Slotmachine
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.casinoslot = new System.Windows.Forms.Label();
            this.pontos = new System.Windows.Forms.Label();
            this.labelwin = new System.Windows.Forms.Label();
            this.labelloss = new System.Windows.Forms.Label();
            this.valordeaposta = new System.Windows.Forms.Label();
            this.botaojogar = new System.Windows.Forms.Button();
            this.botaoaposta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voltar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // casinoslot
            // 
            this.casinoslot.AutoSize = true;
            this.casinoslot.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casinoslot.ForeColor = System.Drawing.Color.Yellow;
            this.casinoslot.Location = new System.Drawing.Point(91, 15);
            this.casinoslot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.casinoslot.Name = "casinoslot";
            this.casinoslot.Size = new System.Drawing.Size(188, 18);
            this.casinoslot.TabIndex = 3;
            this.casinoslot.Text = "Casino slot machine";
            this.casinoslot.Click += new System.EventHandler(this.label1_Click);
            // 
            // pontos
            // 
            this.pontos.AutoSize = true;
            this.pontos.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontos.ForeColor = System.Drawing.Color.LightSlateGray;
            this.pontos.Location = new System.Drawing.Point(19, 48);
            this.pontos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pontos.Name = "pontos";
            this.pontos.Size = new System.Drawing.Size(95, 20);
            this.pontos.TabIndex = 4;
            this.pontos.Text = "Pontos: $";
            this.pontos.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelwin
            // 
            this.labelwin.AutoSize = true;
            this.labelwin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwin.ForeColor = System.Drawing.Color.Lime;
            this.labelwin.Location = new System.Drawing.Point(20, 183);
            this.labelwin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelwin.Name = "labelwin";
            this.labelwin.Size = new System.Drawing.Size(108, 23);
            this.labelwin.TabIndex = 5;
            this.labelwin.Text = "Ganhos: 0";
            // 
            // labelloss
            // 
            this.labelloss.AutoSize = true;
            this.labelloss.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloss.ForeColor = System.Drawing.Color.Red;
            this.labelloss.Location = new System.Drawing.Point(20, 217);
            this.labelloss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelloss.Name = "labelloss";
            this.labelloss.Size = new System.Drawing.Size(125, 23);
            this.labelloss.TabIndex = 6;
            this.labelloss.Text = "Perdidos: 0";
            this.labelloss.Click += new System.EventHandler(this.label4_Click);
            // 
            // valordeaposta
            // 
            this.valordeaposta.AutoSize = true;
            this.valordeaposta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valordeaposta.ForeColor = System.Drawing.Color.Gray;
            this.valordeaposta.Location = new System.Drawing.Point(175, 183);
            this.valordeaposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valordeaposta.Name = "valordeaposta";
            this.valordeaposta.Size = new System.Drawing.Size(164, 23);
            this.valordeaposta.TabIndex = 7;
            this.valordeaposta.Text = "Valor de aposta";
            // 
            // botaojogar
            // 
            this.botaojogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaojogar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaojogar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.botaojogar.Location = new System.Drawing.Point(23, 253);
            this.botaojogar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botaojogar.Name = "botaojogar";
            this.botaojogar.Size = new System.Drawing.Size(112, 41);
            this.botaojogar.TabIndex = 9;
            this.botaojogar.Text = "Apostar";
            this.botaojogar.UseVisualStyleBackColor = true;
            this.botaojogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoaposta
            // 
            this.botaoaposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoaposta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoaposta.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.botaoaposta.Location = new System.Drawing.Point(179, 253);
            this.botaoaposta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botaoaposta.Name = "botaoaposta";
            this.botaoaposta.Size = new System.Drawing.Size(141, 41);
            this.botaoaposta.TabIndex = 10;
            this.botaoaposta.Text = "Nova aposta";
            this.botaoaposta.UseVisualStyleBackColor = true;
            this.botaoaposta.Click += new System.EventHandler(this.botaoaposta_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Slotmachine.Properties.Resources.fumo2;
            this.pictureBox3.Location = new System.Drawing.Point(226, 84);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Slotmachine.Properties.Resources.fumo2;
            this.pictureBox2.Location = new System.Drawing.Point(137, 84);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Slotmachine.Properties.Resources.fumo2;
            this.pictureBox1.Location = new System.Drawing.Point(46, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // voltar
            // 
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.voltar.Location = new System.Drawing.Point(2, 6);
            this.voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(84, 37);
            this.voltar.TabIndex = 11;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(179, 221);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(233, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(340, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.botaoaposta);
            this.Controls.Add(this.botaojogar);
            this.Controls.Add(this.valordeaposta);
            this.Controls.Add(this.labelloss);
            this.Controls.Add(this.labelwin);
            this.Controls.Add(this.pontos);
            this.Controls.Add(this.casinoslot);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label casinoslot;
        private System.Windows.Forms.Label pontos;
        private System.Windows.Forms.Label labelwin;
        private System.Windows.Forms.Label labelloss;
        private System.Windows.Forms.Label valordeaposta;
        private System.Windows.Forms.Button botaojogar;
        private System.Windows.Forms.Button botaoaposta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}

