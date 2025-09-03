using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Repositories
{
    public class ViagemRepository:IViagemRepository
    {
        private readonly List<Viagem> _Viagem;
        private readonly List<Cliente> _Clientes;
        private readonly List<Motorista> _motoristas;
        
        public ViagemRepository()
        {
            // Simulação de dados (poderia vir de banco)
            _motoristas = new List<Motorista>
            {
                new Motorista { Id = 1, Nome = "Carlos Silva", Cnh = "123456789", Ativo = true },
                new Motorista { Id = 2, Nome = "Maria Souza", Cnh = "987654321", Ativo = false },
                new Motorista { Id = 3, Nome = "João Pereira", Cnh = "555444333", Ativo = true }
            };
            // Simulação de dados (poderia vir de banco)
            _Clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nome = "Carlos Silva", Doc = "123456789", Ativo = true },
                new Cliente { Id = 2, Nome = "Maria Souza", Doc = "987654321", Ativo = false },
                new Cliente { Id = 3, Nome = "João Pereira", Doc = "555444333", Ativo = true }
            };

            // Simulação de dados (poderia vir de banco)
            _Viagem = new List<Viagem>
            {
                new Viagem { Id = 1, cliente = _Clientes[0], motorista = _motoristas[0], date = DateTime.Now,localCarga = "Rua 1", Ativo = true },
                new Viagem { Id = 2, cliente = _Clientes[1], motorista = _motoristas[1], date = DateTime.Now,localCarga = "Rua B", Ativo = false },
                new Viagem { Id = 3, cliente = _Clientes[2], motorista = _motoristas[2], date = DateTime.Now,localCarga = "Rua C", Ativo = true }
            };
        }

        public Viagem GetById(int id)
        {
            return _Viagem.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Viagem> GetAll()
        {
            return _Viagem;
        }

        public IEnumerable<Viagem> GetAtivos()
        {
            return _Viagem.Where(m => m.Ativo);
        }

        public void PostViagem(Viagem m)
        {
            _Viagem.Add(m);
        }
    }
}
