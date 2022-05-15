using MySql.Data.MySqlClient;
using prjOdontologia.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOdontologia.DAO
{
    class loginDAOComando
    {
        public bool verificar = false;
        public String mensagem = "";// se a mensagem continuar vazia esta tudo OK, caso contraio apresentará mensagem de erro
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr; // guardar as informações buscada no banco de dados

        /*metodo verificarLogin vai até o banco de dados, verficar se existe o login e a senha
        se verdadeiro a classe controle irá autorizar a entrada no sistema, caso não exista 
        no banco o acesso será negado e exibirá uma mensagem*/
        public bool verificarLogin(String login, String senha)
        {
            //comando sql para verificar no banco
            cmd.CommandText = "SELECT * FROM odon_login WHERE email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.obterConexao();
                dr = cmd.ExecuteReader();

                //verifica se foi encontrado o login e senha
                if (dr.HasRows)
                {
                    verificar = true;
                }
            }
            catch(MySqlException)
            {
                //throw;
                //se houver algum erro apresentar mensagem
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return verificar;
        }

        public String cadastrar(String email, String senha, String confirmarSenha)
        {
            //comando para inserir
            return mensagem;
        }
    }
}
