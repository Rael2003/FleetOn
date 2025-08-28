using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IMotoristaService
    {
        Motorista BuscarPorId(int id);
        IEnumerable<Motorista> ListarTodos();
        IEnumerable<Motorista> ListarAtivos();
        void AdicionarMotorista(Motorista motorista);
        int BuscarUltimo();
    }
}
