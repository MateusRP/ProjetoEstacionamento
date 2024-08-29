using MySqlConnector;
using ProjetoEstacionamento.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.DAO
{
    internal class VeiculoDAO
    {
        private MySqlConnection con;
        private MySqlCommand envelope;
        private MySqlDataReader cursor;
        private string sql;
        private List<VeiculoDTO> lista;
        public VeiculoDAO() {
            con = ConexaoMySQL.Conexao();
        }
        public List<VeiculoDTO> listar()
        {
            lista = new List<VeiculoDTO>();
            try
            {
                con.Open();
                sql = "select * from tbl_veiculo";
                envelope = new MySqlCommand(sql, con);
                cursor = envelope.ExecuteReader();
                while (cursor.Read())
                {
                    int id = cursor.GetInt32("veic_id");
                    string modelo = cursor.GetString("veic_modelo");
                    string cor = cursor.GetString("veic_cor");
                    string placa = cursor.GetString("veic_placa");
                    DateTime hora_entrada = cursor.GetDateTime("veic_hora_entrada");
                    DateTime hora_saida;
                    try
                    {
                        hora_saida = cursor.GetDateTime("veic_hora_saida");
                    }
                    catch (Exception e) 
                    {
                        hora_saida = DateTime.MinValue;
                    }
                    
                    VeiculoDTO v = new VeiculoDTO(id, modelo, cor, placa, hora_entrada, hora_saida);
                    lista.Add(v);
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
        public int salvar(VeiculoDTO v)
        {
            int resultado = 0;
            try
            {
                con.Open();
                sql = "Insert into tbl_veiculo(veic_modelo, veic_cor, veic_placa, veic_hora_entrada) values (@modelo,@cor,@placa,@hora)";
                envelope = new MySqlCommand(sql, con);
                envelope.Parameters.AddWithValue("@modelo",v.Modelo);
                envelope.Parameters.AddWithValue("@cor",v.Cor);
                envelope.Parameters.AddWithValue("@placa", v.Placa);
                envelope.Parameters.AddWithValue("@hora",v.HorEntrada);
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
        public int atualizar(VeiculoDTO v)
        {
            int resultado = 0;
            try
            {
                con.Open();
                sql = "Update tbl_veiculo set veic_hora_saida = @hora where veic_id = @id";
                envelope = new MySqlCommand(sql, con);
                envelope.Parameters.AddWithValue("@hora", v.HorSaida);
                envelope.Parameters.AddWithValue("@id", v.Id);
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
