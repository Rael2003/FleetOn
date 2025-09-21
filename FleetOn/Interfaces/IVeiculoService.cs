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
        void AdicionarVeiculo(Veiculo Veiculo);
        int BuscarUltimo();
        void DeletaVeiculo(int id);
        void AtualizaVeiculo(int id, Veiculo Veiculo);
    }
}
