using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Models
{
    public class Viagem
    {
        public int Id { get; set; }
        public Cliente cliente {  get; set; }
        public Motorista motorista { get; set; }
        public DateTime date { get; set; }
        public string localCarga { get; set; }
        public bool Ativo {  get; set; }

    }
}
