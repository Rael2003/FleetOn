using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Repositories
{
    public class MotoristaRepository : IMotoristaRepository
    {
        private readonly List<Motorista> _motoristas;

        public MotoristaRepository()
        {
            // Simulação de dados (poderia vir de banco)
            _motoristas = new List<Motorista>
        {
            new Motorista { Id = 1, Nome = "Carlos Silva", Cnh = "123456789", Ativo = true },
            new Motorista { Id = 2, Nome = "Maria Souza", Cnh = "987654321", Ativo = false },
            new Motorista { Id = 3, Nome = "João Pereira", Cnh = "555444333", Ativo = true }
        };
        }

        public Motorista GetById(int id)
        {
            return _motoristas.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Motorista> GetAll()
        {
            return _motoristas;
        }

        public IEnumerable<Motorista> GetAtivos()
        {
            return _motoristas.Where(m => m.Ativo);
        }

        public void PostMotorista(Motorista m)
        {
            _motoristas.Add(m);
        }
    }
}
