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
    public class MotoristaController
    {
        private readonly IMotoristaService _motoristaService;
        public MotoristaController(IMotoristaService motoristaService)
        {
            _motoristaService = motoristaService;
        }

        public IEnumerable<Motorista> ConsultarMotoristas()
        {
            return _motoristaService.ListarAtivos();
        }
    }
}
