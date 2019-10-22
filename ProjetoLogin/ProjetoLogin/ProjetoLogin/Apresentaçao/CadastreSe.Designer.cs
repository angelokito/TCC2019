namespace ProjetoLogin.Apresentaçao
{
    partial class CadastreSe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txblogar = new System.Windows.Forms.TextBox();
            this.txbsen = new System.Windows.Forms.TextBox();
            this.cofsenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Corfirmar Senha";
            // 
            // txblogar
            // 
            this.txblogar.Location = new System.Drawing.Point(75, 50);
            this.txblogar.Name = "txblogar";
            this.txblogar.Size = new System.Drawing.Size(208, 20);
            this.txblogar.TabIndex = 3;
            this.txblogar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbsen
            // 
            this.txbsen.Location = new System.Drawing.Point(75, 124);
            this.txbsen.Name = "txbsen";
            this.txbsen.PasswordChar = '*';
            this.txbsen.Size = new System.Drawing.Size(100, 20);
            this.txbsen.TabIndex = 4;
            // 
            // cofsenha
            // 
            this.cofsenha.Location = new System.Drawing.Point(75, 205);
            this.cofsenha.Name = "cofsenha";
            this.cofsenha.PasswordChar = '*';
            this.cofsenha.Size = new System.Drawing.Size(100, 20);
            this.cofsenha.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(111, 265);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar-se";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 417);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cofsenha);
            this.Controls.Add(this.txbsen);
            this.Controls.Add(this.txblogar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastreSe";
            this.Text = "CadastreSe";
            this.Load += new System.EventHandler(this.CadastreSe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txblogar;
        private System.Windows.Forms.TextBox txbsen;
        private System.Windows.Forms.TextBox cofsenha;
        private System.Windows.Forms.Button btnCadastrar;
    }
}