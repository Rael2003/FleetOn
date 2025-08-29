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
    public class VeiculoController
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService) 
        {
            _veiculoService = veiculoService;
        }

        public IEnumerable<Veiculo> ConsultarVeiculos()
        {
            return _veiculoService.ListarAtivos();
        }

        public void AdicionarVeiculo(Veiculo motorista)
        {
            motorista.Id = _veiculoService.BuscarUltimo() + 1;
            _veiculoService.AdicionarMotorista(motorista);
        }
    }
}
