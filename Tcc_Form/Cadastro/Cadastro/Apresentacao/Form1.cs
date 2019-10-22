using Cadastro.Apresentacao;
using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Controller controle = new Controller();
            controle.Acessar(txbLogin txtsenha.Text);
            if (controle.mensagem.Equals(""))
            {


                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso.", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique seu Login e Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
        

