using FleetOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Interfaces
{
    public interface IVeiculoService
    {
        Veiculo BuscarPorId(int id);
        IEnumerable<Veiculo> ListarTodos();
        IEnumerable<Veiculo> ListarAtivos();
        void AdicionarMotorista(Veiculo motorista);
        int BuscarUltimo();
    }
}
