using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    internal class Conexao
    {
        // criar todos os métodos relacionados ao BD método de conexão do banco
        // string de conexao

        private string stringConexao = 
            "server=localhost;database=sistemaescolar;uid=root;pwd=''";

        public void conectar()
        {
            using (MySql.Data.MySqlClient.MySqlConnection conexao = new MySql.Data.MySqlClient.MySqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
    }
}
