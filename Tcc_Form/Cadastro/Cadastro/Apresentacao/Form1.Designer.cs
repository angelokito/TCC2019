namespace Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnsair = new System.Windows.Forms.Button();
            this.btnentrar = new System.Windows.Forms.Button();
            this.lblogin = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbsenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsair.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnsair.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(50)))), ((int)(((byte)(1)))));
            this.btnsair.Location = new System.Drawing.Point(677, -1);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 31);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.Black;
            this.btnentrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnentrar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.ForeColor = System.Drawing.Color.LightBlue;
            this.btnentrar.Location = new System.Drawing.Point(596, -1);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(75, 31);
            this.btnentrar.TabIndex = 1;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.BackColor = System.Drawing.Color.Black;
            this.lblogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.ForeColor = System.Drawing.Color.Yellow;
            this.lblogin.Location = new System.Drawing.Point(185, 61);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(65, 20);
            this.lblogin.TabIndex = 2;
            this.lblogin.Text = "LOGIN:";
            this.lblogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(314, 97);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(179, 22);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.White;
            this.txtlogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.Black;
            this.txtlogin.Location = new System.Drawing.Point(254, 60);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(239, 22);
            this.txtlogin.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbsenha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbsenha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenha.ForeColor = System.Drawing.Color.Yellow;
            this.lbsenha.Location = new System.Drawing.Point(240, 100);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(68, 20);
            this.lbsenha.TabIndex = 6;
            this.lbsenha.Text = "SENHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(552, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "UbiWork Corporation 2019";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InfoText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(2, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = " UbiWork Securety";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(499, 119);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu sua senha?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(499, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(499, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 373);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.btnsair);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

