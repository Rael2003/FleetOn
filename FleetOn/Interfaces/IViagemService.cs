using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IViagemService
    {
        Viagem BuscarPorId(int id);
        IEnumerable<Viagem> ListarTodos();
        IEnumerable<Viagem> ListarAtivos();
        void AdicionarMotorista(Viagem motorista);
        int BuscarUltimo();
    }
}
