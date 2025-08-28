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
    }
}
