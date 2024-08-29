using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEstacionamento.DTO;

namespace ProjetoEstacionamento.Controller
{
    internal class ControllerLogin
    {
        private List<FuncionarioDTO> funcionario_lista;
        private List<GerenteDTO> gerente_lista;
        public ControllerLogin()
        {
            funcionario_lista = new List<FuncionarioDTO>();
            gerente_lista = new List<GerenteDTO>();

            Funcionario_lista.Add(new FuncionarioDTO("Fulano",
                "Porteiro",
                "fulano",
                "1234"));
            Funcionario_lista.Add(new FuncionarioDTO("Cicrano",
                "Porteiro",
                "cicrano",
                "abcde"));
            Funcionario_lista.Add(new FuncionarioDTO("Beltrano",
                "Frentista",
                "beltrano",
                "12341234"));

            Gerente_lista.Add(new GerenteDTO("Mateus Rodrigues Pereira",
                "mateus",
                "12345678"));
        }

        internal List<FuncionarioDTO> Funcionario_lista { get => funcionario_lista; set => funcionario_lista = value; }
        internal List<GerenteDTO> Gerente_lista { get => gerente_lista; set => gerente_lista = value; }

        public int Login(string usuario, string senha)
        {

            for (int i = 0; i < Funcionario_lista.Count; i++)
            {
                if (usuario == Funcionario_lista[i].Usuario &&
                    senha == Funcionario_lista[i].Senha)
                {

                    return 1;
                }
            }
            for (int i = 0; i < Gerente_lista.Count; i++)
            {
                if (usuario == Gerente_lista[i].Usuario &&
                    senha == Gerente_lista[i].Senha)
                {
                    return 2;
                }
            }
            return 0;
        }
    }
}
