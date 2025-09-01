using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IClienteService
    {
        Cliente BuscarPorId(int id);
        IEnumerable<Cliente> ListarTodos();
        IEnumerable<Cliente> ListarAtivos();
        void AdicionarCliente(Cliente Cliente);
        int BuscarUltimo();
    }
}
