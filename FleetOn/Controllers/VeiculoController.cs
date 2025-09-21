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

        public Veiculo ConsultarVeiculo(int id)
        {
            return _veiculoService.BuscarPorId(id);
        }

        public void AdicionarVeiculo(Veiculo Veiculo)
        {
            Veiculo.Id = _veiculoService.BuscarUltimo() + 1;
            _veiculoService.AdicionarVeiculo(Veiculo);
        }

        public void DeletaVeiculo(int id)
        {
            _veiculoService.DeletaVeiculo(id);
        }

        public void AtualizaVeiculo(int id, Veiculo Veiculo)
        {
            _veiculoService.AtualizaVeiculo(id, Veiculo);
        }
    }
}
