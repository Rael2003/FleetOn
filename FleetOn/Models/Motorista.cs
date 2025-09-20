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
        public string Categoria_cnh { get; set; }
        public bool Ativo { get; set; }

        public Motorista(int id, string nome,string cnh, string categoria_cnh)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cnh = cnh;
            this.Ativo = true;
            this.Categoria_cnh = categoria_cnh;
        }

        public Motorista() { }
    }
}
