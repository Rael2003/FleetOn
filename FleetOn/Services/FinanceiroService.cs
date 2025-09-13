using FleetOn.DTOs;
using FleetOn.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Services
{
    public class FinanceiroService
    {
        private readonly IFinanceiroRepository _repository;
        public IEnumerable<FinanceiroDTO> BuscarFinanceiro()
        {
            return _repository.GetFinanceiro();
        }
    }
}
