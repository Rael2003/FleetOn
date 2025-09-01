using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Repositories
{
    public class ClienteRepository:IClienteRepository
    {
        private readonly List<Cliente> _Clientes;

        public ClienteRepository()
        {
            // Simulação de dados (poderia vir de banco)
            _Clientes = new List<Cliente>
        {
            new Cliente { Id = 1, Nome = "Carlos Silva", Doc = "123456789", Ativo = true },
            new Cliente { Id = 2, Nome = "Maria Souza", Doc = "987654321", Ativo = false },
            new Cliente { Id = 3, Nome = "João Pereira", Doc = "555444333", Ativo = true }
        };
        }

        public Cliente GetById(int id)
        {
            return _Clientes.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _Clientes;
        }

        public IEnumerable<Cliente> GetAtivos()
        {
            return _Clientes.Where(m => m.Ativo);
        }

        public void PostCliente(Cliente m)
        {
            _Clientes.Add(m);
        }
    }
}
