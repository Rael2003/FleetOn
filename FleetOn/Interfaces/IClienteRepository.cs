using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IClienteRepository
    {
        Cliente GetById(int id);
        IEnumerable<Cliente> GetAll();
        IEnumerable<Cliente> GetAtivos();
        void PostCliente(Cliente Cliente);
        void DeleteCliente(int id);
        void UpdateCliente(int id,  Cliente Cliente);
    }
}
