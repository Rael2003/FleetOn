using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Repositories
{
    public class VeiculoRepository:IVeiculoRepository
    {
        private readonly List<Veiculo> _veiculo;

        public VeiculoRepository() 
        {
            // Simulação de dados (poderia vir de banco)
            _veiculo = new List<Veiculo>
            {
                new Veiculo { Id = 1, NomeVeiculo = "Carlos Silva", Placa = "123456789", Ativo = true },
                new Veiculo { Id = 2, NomeVeiculo = "Maria Souza", Placa = "987654321", Ativo = false },
                new Veiculo { Id = 3, NomeVeiculo = "João Pereira", Placa = "555444333", Ativo = true }
            };
        }

        public Veiculo GetById(int id)
        {
            return _veiculo.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Veiculo> GetAll()
        {
            return _veiculo;
        }

        public IEnumerable<Veiculo> GetAtivos()
        {
            return _veiculo.Where(m => m.Ativo);
        }

        public void PostVeiculo(Veiculo m)
        {
            _veiculo.Add(m);
        }
    }
}
