using ProjetoEstacionamento.DAO;
using ProjetoEstacionamento.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Controller
{
    internal class ControllerVeiculo
    {
        public ControllerVeiculo() { }

        public List<VeiculoDTO> listaVeiculos()
        {
            VeiculoDAO veiculoDAO = new VeiculoDAO();
            return veiculoDAO.listar();
        }

        public int salvarVeiculo(string modelo, string cor, string placa)
        {
            if (modelo == "" || cor == "" || placa == "")
            {
                return -1;
            }
            VeiculoDTO vDTO = new VeiculoDTO(modelo, cor, placa, DateTime.Now);
            VeiculoDAO vDAO = new VeiculoDAO();
            int resultado = vDAO.salvar(vDTO);

            return resultado;
        }

        public int fecharVeiculo(int id, string modelo, string cor, string placa, DateTime hora_entrada) 
        {
            VeiculoDTO vDTO = new(id, modelo, cor, placa, hora_entrada, DateTime.Now);
            VeiculoDAO vDAO = new VeiculoDAO();

            int resultado = vDAO.atualizar(vDTO);
            return resultado;
        }
    }
}
