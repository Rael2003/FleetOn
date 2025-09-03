using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IViagemRepository
    {
        Viagem GetById(int id);
        IEnumerable<Viagem> GetAll();
        IEnumerable<Viagem> GetAtivos();
        void PostViagem(Viagem motorista);
    }
}
