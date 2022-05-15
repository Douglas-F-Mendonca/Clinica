using MySql.Data.MySqlClient;
using prjOdontologia.Class;
using prjOdontologia.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOdontologia.Model
{
    public class Controle
    {
        public bool verificar;
        public String mensagem = "";

        //Criando método para acessar e para cadastrar funcionário
        public bool acessar(String login, String senha)// com 2 paramêtros e vai retornar um valor booleano
        {
            loginDAOComando loginDAO = new DAO.loginDAOComando();
            verificar = loginDAO.verificarLogin(login, senha);

            //verificação se há algum erro no codigo
            if (!loginDAO.mensagem.Equals(""))
            {
                this.mensagem = loginDAO.mensagem;
            }
            return verificar;
        }

        public String cadastrar(String email, String senha, String confirmarSenha)
        {
            return mensagem;
        }
    }
}
