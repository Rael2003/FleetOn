using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Services
{
    public class ViagemService:IViagemService
    {
        private readonly IViagemRepository _repository;

        public ViagemService(IViagemRepository repository)
        {
            _repository = repository;
        }

        public Viagem BuscarPorId(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Viagem> ListarTodos()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Viagem> ListarAtivos()
        {
            return _repository.GetAtivos();
        }

        public void AdicionarMotorista(Viagem motorista)
        {
            _repository.PostViagem(motorista);
        }

        public int BuscarUltimo()
        {
            return _repository.GetAll().Count();
        }
    }
}
