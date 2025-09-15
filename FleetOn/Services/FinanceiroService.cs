using FleetOn.DTOs;
using FleetOn.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Services
{
    public class FinanceiroService : IFinanceiroService
    {
        private readonly IFinanceiroRepository _repository;
        public FinanceiroService(IFinanceiroRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<FinanceiroDTO> BuscarFinanceiro()
        {
            return _repository.GetFinanceiro();
        }
    }
}
