using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.DTO
{
    internal class VeiculoDTO
    {
        private int id;
        private string modelo;
        private string cor;
        private string placa;
        private DateTime horEntrada;
        private DateTime horSaida;

        public VeiculoDTO(int id, string modelo, string cor, string placa, DateTime horEntrada, DateTime horSaida)
        {
            this.id = id;
            this.modelo = modelo;
            this.cor = cor;
            this.placa = placa;
            this.horEntrada = horEntrada;
            this.horSaida = horSaida;
        }
        public VeiculoDTO(string modelo, string cor, string placa, DateTime horEntrada)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.placa = placa;
            this.horEntrada = horEntrada;
        }
        public int Id { get => id; set => id = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime HorEntrada { get => horEntrada; set => horEntrada = value; }
        public DateTime HorSaida { get => horSaida; set => horSaida = value; }

    }
}
