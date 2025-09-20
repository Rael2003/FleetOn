using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IMotoristaRepository
    {
        Motorista GetById(int id);
        IEnumerable<Motorista> GetAll();
        IEnumerable<Motorista> GetAtivos();
        void PostMotorista(Motorista motorista);
        void DeleteMotorista(int id);
        void UpdateMotorista(int id, Motorista motorista);
    }
}
