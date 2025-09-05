using FleetOn.Interfaces;
using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Controllers
{
    public class ClienteController
    {
        private readonly IClienteService _ClienteService;
        public ClienteController(IClienteService ClienteService)
        {
            _ClienteService = ClienteService;
        }

        public IEnumerable<Cliente> ConsultarClientes()
        {
            return _ClienteService.ListarAtivos();
        }

        public void AdicionarCliente(Cliente Cliente)
        {
            Cliente.Id = _ClienteService.BuscarUltimo() + 1;
            _ClienteService.AdicionarCliente(Cliente);
        }

        public Cliente BuscarCliente(int id)
        {
            return _ClienteService.BuscarPorId(id);
        }
    }
}
