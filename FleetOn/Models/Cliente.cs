using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Doc { get; set; }
        public bool Ativo {  get; set; }

        public Cliente() { }

        public Cliente(int id, string nome, string doc, bool ativo)
        {
            Id = id;
            Nome = nome;
            Doc = doc;
            Ativo = ativo;
        }
    }
}
