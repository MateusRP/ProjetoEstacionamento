using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.DAO
{
    internal class ConexaoMySQL
    {
        private static string host = "localhost";
        private static string user = "root";
        private static string pass = "";
        private static string db = "estacionamento";

        public static MySqlConnection Conexao()
        {
            MySqlConnection con = null;
            string strcon = $"server={host};userid={user};password={pass};database={db}";
            try
            {
                con = new MySqlConnection(strcon);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
}
