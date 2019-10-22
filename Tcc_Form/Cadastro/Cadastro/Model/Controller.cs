using System;
using System.Windows.Forms;
using ProjetoLogin.DAL;

namespace Cadastro.Model
{
    public class Controller
    {
        public bool tem;
        public String mensagem = "";

        public bool Acessar(String login, String senha)
        {
            LoginDaoComandos  loginDao= new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha,String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
           this.mensagem = loginDao.cadastrar(email, senha, confSenha);

            if (loginDao.tem)
            {
                this.tem = true;
    }
            return mensagem;
        }

      
    }
}

