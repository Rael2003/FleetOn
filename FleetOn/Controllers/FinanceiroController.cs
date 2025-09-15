using FleetOn.DTOs;
using FleetOn.Interfaces;
using FleetOn.Models;
using FleetOn.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Controllers
{
    public class FinanceiroController
    {
        private readonly IFinanceiroService _financeiroService;
        public FinanceiroController(IFinanceiroService FinanceiroService)
        {
            _financeiroService = FinanceiroService;
        }

        public IEnumerable<FinanceiroDTO> ConsultarFinanceiro()
        {
            return _financeiroService.BuscarFinanceiro();
        }

    }
}
