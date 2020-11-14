using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TI_DB.Classes
{
    class DAL
    {
        private static string servidor = "localhost";
        private static string banco = "db_ti";
        private static string user = "root";
        private static string password = "123456";

        private string string_conexao = "Server=" + servidor + ";Database=" + banco + ";Uid=" + user + ";Pwd=" + password;
        public MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection();
                conexao.ConnectionString = string_conexao;
                conexao.Open();
            }
            catch (Exception)
            {

                throw;
            }

        }

        //INSERT, UPDATE E DELETE
        public void ExecutarComandoSQL(string sql)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }


        }

        //RODA APENAS SELECT
        public DataTable RetDataTable(string comando_select)
        {
            try
            {
                DataTable dados = new DataTable(); //Retorno para o meu GRID ou COMBOBOX
                MySqlDataAdapter da = new MySqlDataAdapter(); //Adaptador de dados do Mysql para o C#
                MySqlCommand comando = new MySqlCommand(); //Comando a ser utilizado pelo adaptador

                comando.Connection = conexao;
                comando.CommandText = comando_select;
                da.SelectCommand = comando;

                da.Fill(dados); //Preenche  o objeto dados com os dados recuperados no bd
                return dados;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
