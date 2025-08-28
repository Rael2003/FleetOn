using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Services
{
    public class MotoristaService : IMotoristaService
    {
        private readonly IMotoristaRepository _repository;

        public MotoristaService(IMotoristaRepository repository)
        {
            _repository = repository;
        }

        public Motorista BuscarPorId(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Motorista> ListarTodos()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Motorista> ListarAtivos()
        {
            return _repository.GetAtivos();
        }

        public void AdicionarMotorista(Motorista motorista)
        {
            _repository.PostMotorista(motorista);
        }

        public int BuscarUltimo()
        {
            return _repository.GetAll().Count();  
        }
    }
}
