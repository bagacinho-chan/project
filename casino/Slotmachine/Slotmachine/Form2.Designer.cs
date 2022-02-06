
namespace Slotmachine
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoJogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.voltar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mudarFundoToolStripMenuItem,
            this.instruçõesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // mudarFundoToolStripMenuItem
            // 
            this.mudarFundoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretoToolStripMenuItem,
            this.azulToolStripMenuItem,
            this.brancoToolStripMenuItem});
            this.mudarFundoToolStripMenuItem.Name = "mudarFundoToolStripMenuItem";
            this.mudarFundoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mudarFundoToolStripMenuItem.Text = "Mudar fundo";
            // 
            // pretoToolStripMenuItem
            // 
            this.pretoToolStripMenuItem.Name = "pretoToolStripMenuItem";
            this.pretoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretoToolStripMenuItem.Text = "Preto";
            this.pretoToolStripMenuItem.Click += new System.EventHandler(this.pretoToolStripMenuItem_Click);
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // brancoToolStripMenuItem
            // 
            this.brancoToolStripMenuItem.Name = "brancoToolStripMenuItem";
            this.brancoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brancoToolStripMenuItem.Text = "Branco";
            this.brancoToolStripMenuItem.Click += new System.EventHandler(this.brancoToolStripMenuItem_Click);
            // 
            // instruçõesToolStripMenuItem
            // 
            this.instruçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoJogarToolStripMenuItem});
            this.instruçõesToolStripMenuItem.Name = "instruçõesToolStripMenuItem";
            this.instruçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instruçõesToolStripMenuItem.Text = "Instruções";
            // 
            // comoJogarToolStripMenuItem
            // 
            this.comoJogarToolStripMenuItem.Name = "comoJogarToolStripMenuItem";
            this.comoJogarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comoJogarToolStripMenuItem.Text = "Como jogar";
            this.comoJogarToolStripMenuItem.Click += new System.EventHandler(this.comoJogarToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 76);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Inserir um valor para apostar e clicar em \"Apostar\"\r\nDepois de apostar tem a esco" +
    "lha de \"Nova Aposta\" em que pode inserir um novo valor\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.voltar.Location = new System.Drawing.Point(229, 289);
            this.voltar.Margin = new System.Windows.Forms.Padding(2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(84, 37);
            this.voltar.TabIndex = 12;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 337);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudarFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoJogarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button voltar;
    }
}