using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public Cliente BuscarPorId(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Cliente> ListarTodos()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Cliente> ListarAtivos()
        {
            return _repository.GetAtivos();
        }

        public void AdicionarCliente(Cliente Cliente)
        {
            _repository.PostCliente(Cliente);
        }

        public int BuscarUltimo()
        {
            return _repository.GetAll().Count();
        }

        public void DeletaCliente(int id)
        {
            _repository.DeleteCliente(id);
        }

        public void AtualizaCliente(int id, Cliente cliente)
        {
            _repository.UpdateCliente(id, cliente);
        }
    }
}
