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

        public void AdicionarMotorista(Motorista motorista)
        {
            motorista.Id = _motoristaService.BuscarUltimo() + 1;
            _motoristaService.AdicionarMotorista(motorista);
        }

        public Motorista BuscarMotorista(int id)
        {
            return _motoristaService.BuscarPorId(id);
        }
    }
}
