using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IVeiculoRepository
    {
        Veiculo GetById(int id);
        IEnumerable<Veiculo> GetAll();
        IEnumerable<Veiculo> GetAtivos();
        void PostVeiculo(Veiculo motorista);
    }
}
