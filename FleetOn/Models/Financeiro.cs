using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Models
{
    public class Financeiro
    {
        int id_financeiro { get; set; }
        Viagem id_viagem { get; set; }
        string tipo { get; set; }
        string descricao { get; set; }
        float valor { get; set; }
        DateTime data_lancamento { get; set; }
    }
}
