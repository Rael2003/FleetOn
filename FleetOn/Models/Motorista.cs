using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Models
{
    public class Motorista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnh { get; set; }
        public bool Ativo { get; set; }

        public Motorista(string nome,string cnh)
        {
            this.Id = 0;
            this.Nome = nome;
            this.Cnh = cnh;
            this.Ativo = true;
        }

        public Motorista() { }
    }
}
