using ProjetoEstacionamento.DAO;
using ProjetoEstacionamento.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Controller
{
    internal class ControllerFuncionario
    {
        public ControllerFuncionario() { }
        public List<FuncionarioDTO> listarFuncionarios()
        {
            FuncionarioDAO func = new FuncionarioDAO();
            return func.listar();
        }
        public int salvarFuncionario(string nome, string cargo, string usuario, string senha)
        {
            if (nome == "" || cargo == "" || usuario == "" || senha == "")
            {
                return -1;
            }
            FuncionarioDTO funcDTO = new FuncionarioDTO(nome, cargo, usuario, senha);
            FuncionarioDAO funcDAO = new FuncionarioDAO();
            int resultado = funcDAO.salvar(funcDTO);

            return resultado;
        }
        public int atualizarFuncionario(int id, string nome, string cargo, string usuario, string senha)
        {
            if (nome == "" || cargo == "" || usuario == "" || senha == "")
            {
                return -1;
            }
            FuncionarioDTO funcDTO = new FuncionarioDTO(id, nome, cargo, usuario, senha);
            FuncionarioDAO funcDAO = new FuncionarioDAO();
            int resultado = funcDAO.atualizar(funcDTO);
            return resultado;
        }
        
    }
}
