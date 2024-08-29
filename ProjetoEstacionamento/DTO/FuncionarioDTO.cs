using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.DTO
{
    internal class FuncionarioDTO
    {
        private int id;
        private string nome;
        private string cargo;
        private string usuario;
        private string senha;

        public FuncionarioDTO(int id, string nome, string cargo, string usuario, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.cargo = cargo;
            this.usuario = usuario;
            this.senha = senha;
        }
        public FuncionarioDTO(string nome, string cargo, string usuario, string senha)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.usuario = usuario;
            this.senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
