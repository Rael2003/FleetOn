using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Controllers
{
    public class ViagemController
    {
        private readonly IViagemService _ViagemService;
        public ViagemController(IViagemService ViagemService)
        {
            _ViagemService = ViagemService;
        }

        public IEnumerable<Viagem> ConsultarViagems()
        {
            return _ViagemService.ListarAtivos();
        }

        public void AdicionarViagem(Viagem motorista)
        {
            motorista.Id = _ViagemService.BuscarUltimo() + 1;
            _ViagemService.AdicionarMotorista(motorista);
        }
    }
}
