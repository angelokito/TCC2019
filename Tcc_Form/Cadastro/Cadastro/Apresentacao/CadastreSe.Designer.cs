using System;

namespace Cadastro.Apresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastreSe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txbconfiS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnca
            // 
            this.btnca.BackColor = System.Drawing.Color.Black;
            this.btnca.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnca.ForeColor = System.Drawing.Color.Yellow;
            this.btnca.Location = new System.Drawing.Point(50, 309);
            this.btnca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnca.Name = "btnca";
            this.btnca.Size = new System.Drawing.Size(185, 46);
            this.btnca.TabIndex = 2;
            this.btnca.Text = "Cadastrar";
            this.btnca.UseVisualStyleBackColor = false;
            this.btnca.Click += new System.EventHandler(this.btnCadastreSe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(18, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Corfirmar Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.Color.White;
            this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.Location = new System.Drawing.Point(18, 92);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(270, 14);
            this.txbLogin.TabIndex = 4;
            this.txbLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbsenha
            // 
            this.txbsenha.BackColor = System.Drawing.Color.White;
            this.txbsenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsenha.Location = new System.Drawing.Point(18, 176);
            this.txbsenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '*';
            this.txbsenha.Size = new System.Drawing.Size(270, 14);
            this.txbsenha.TabIndex = 5;
            this.txbsenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbconfiS
            // 
            this.txbconfiS.BackColor = System.Drawing.Color.White;
            this.txbconfiS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbconfiS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbconfiS.Location = new System.Drawing.Point(18, 274);
            this.txbconfiS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbconfiS.Name = "txbconfiS";
            this.txbconfiS.PasswordChar = '*';
            this.txbconfiS.Size = new System.Drawing.Size(270, 14);
            this.txbconfiS.TabIndex = 6;
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 409);
            this.Controls.Add(this.txbconfiS);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CadastreSe";
            this.Text = "Cadastre-se já";
            this.Load += new System.EventHandler(this.CadastreSe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CadastreSe_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.TextBox txbconfiS;
    }
}