using FleetOn.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IFinanceiroRepository
    {
        IEnumerable<FinanceiroDTO> GetFinanceiro();
    }
}
