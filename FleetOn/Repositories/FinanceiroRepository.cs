using FleetOn.DTOs;
using FleetOn.Interfaces;
using FleetOn.Models;
using FleetOn.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Repositories
{
    public class FinanceiroRepository: IFinanceiroRepository
    {
        private readonly ViagemService _Viagem;
        public IEnumerable<FinanceiroDTO> GetFinanceiro()
        {
            var lista = new List<FinanceiroDTO>();

            string sql = "SELECT id_financeiro, id_viagem, valor FROM financeiro";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new FinanceiroDTO
                {
                    id_financeiro = (int)row["id_financeiro"],
                    id_viagem = _Viagem.BuscarPorId((int)row["id_viagem"]),
                    valor = (float)row["valor"],
                    data_lancamento = (DateTime)row["data_lancamento"]
                });
            }

            return lista;
        }
    }
}
