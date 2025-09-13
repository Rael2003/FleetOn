using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.DTOs
{
    public class FinanceiroDTO
    {
        public int id_financeiro { get; set; }
        public Viagem id_viagem { get; set; }
        public float valor { get; set; }
        public DateTime data_lancamento { get; set; }
    }
}
