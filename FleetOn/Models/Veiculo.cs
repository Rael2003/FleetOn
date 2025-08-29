using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string NomeVeiculo { get; set; }
        public string Placa { get; set; }

        public bool Ativo {  get; set; }

        public Veiculo() { }

        public Veiculo(int id, string nomeVeiculo, string placa, bool ativo )
        {
            Id = id;
            NomeVeiculo = nomeVeiculo;
            Placa = placa;
            Ativo = ativo;
        }
    }
}
