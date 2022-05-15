using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prjOdontologia.Class
{
    public class Conexao
    {
        MySqlConnection conn = new MySqlConnection();
        public Conexao()
        {
            conn.ConnectionString  = @"Server=localhost;Database=odontologica;Uid=root;Pwd=;";
        }

        public MySqlConnection obterConexao()
        {
            //verifica se já existe uma conexao com banco.
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void fecharConexao()
        {
            //verifica se a conexão ja foi fechada
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
