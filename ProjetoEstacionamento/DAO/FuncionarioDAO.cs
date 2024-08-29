using MySqlConnector;
using ProjetoEstacionamento.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.DAO
{
    internal class FuncionarioDAO
    {
        private MySqlConnection con;
        private MySqlCommand envelope;
        private MySqlDataReader cursor;
        private string sql;
        private List<FuncionarioDTO> lista;
        public FuncionarioDAO() {
            con = ConexaoMySQL.Conexao();
        }
        public List<FuncionarioDTO> listar()
        {
            lista = new List<FuncionarioDTO>();
            try
            {
                con.Open();
                sql = "select * from tbl_funcionario";
                envelope = new MySqlCommand(sql, con);
                cursor = envelope.ExecuteReader();
                while (cursor.Read())
                {
                    int id = cursor.GetInt32("func_id");
                    string nome = cursor.GetString("func_nome");
                    string cargo = cursor.GetString("func_cargo");
                    string usuario = cursor.GetString("func_usuario");
                    string senha = cursor.GetString("func_senha");
                    FuncionarioDTO func = new FuncionarioDTO(id, nome, cargo, usuario, senha);
                    lista.Add(func);
                }
            }
            catch (MySqlException e)
            {
                throw;
            }
            finally
            { 
                con.Close();
            }

            return lista;
        }
        public int salvar(FuncionarioDTO func)
        {
            int resultado = 0;
            try
            {
                con.Open();
                sql = "Insert into tbl_funcionario(func_nome, func_cargo, func_usuario, func_senha) values(@nome,@cargo,@usuario,@senha)";
                envelope = new MySqlCommand(sql, con);
                envelope.Parameters.AddWithValue("@nome", func.Nome);
                envelope.Parameters.AddWithValue("@cargo", func.Cargo);
                envelope.Parameters.AddWithValue("@usuario", func.Usuario);
                envelope.Parameters.AddWithValue("@senha", func.Senha);
                envelope.Prepare();
                resultado = envelope.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return resultado;
        }

        public int atualizar(FuncionarioDTO func)
        {
            int resultado = 0;

            try
            {
                con.Open();
                sql = "Update tbl_funcionario set func_nome = @nome, func_cargo = @cargo, func_usuario = @usuario, func_senha = @senha where func_id = @id";
                envelope = new MySqlCommand(sql, con);
                envelope.Parameters.AddWithValue("@nome", func.Nome);
                envelope.Parameters.AddWithValue("@cargo", func.Cargo);
                envelope.Parameters.AddWithValue("@usuario", func.Usuario);
                envelope.Parameters.AddWithValue("@senha", func.Senha);
                envelope.Parameters.AddWithValue("@id", func.Id);
                envelope.Prepare();
                resultado = envelope.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return resultado;
        }

        public int apagar(int id)
        {
            int resultado = 0;
            try
            {
                con.Open();
                sql = "Delete from tbl_funcionario where func_id = @id";
                envelope = new MySqlCommand(sql, con);
                envelope.Parameters.AddWithValue("@id", id);
                envelope.Prepare();
                resultado = envelope.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return resultado;
        }
    }
}
