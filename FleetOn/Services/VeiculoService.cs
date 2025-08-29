using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Services
{
    public class VeiculoService:IVeiculoService
    {
        private readonly IVeiculoRepository _repository;

        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }

        public Veiculo BuscarPorId(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Veiculo> ListarTodos()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Veiculo> ListarAtivos()
        {
            return _repository.GetAtivos();
        }

        public void AdicionarMotorista(Veiculo motorista)
        {
            _repository.PostVeiculo(motorista);
        }

        public int BuscarUltimo()
        {
            return _repository.GetAll().Count();
        }
    }
}
