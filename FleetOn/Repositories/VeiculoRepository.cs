using FleetOn.Interfaces;
using FleetOn.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Repositories
{
    public class VeiculoRepository:IVeiculoRepository
    {
        private readonly List<Veiculo> _veiculo;
        public Veiculo GetById(int id)
        {
            return _veiculo.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Veiculo> GetAll()
        {
            var lista = new List<Veiculo>();

            string sql = "SELECT id_Veiculo, placa, modelo FROM veiculos";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Veiculo
                {
                    Id = (int)row["id_Veiculo"],
                    Placa = row["placa"].ToString(),
                    NomeVeiculo = row["modelo"].ToString()
                });
            }

            return lista;
        }

        public IEnumerable<Veiculo> GetAtivos()
        {
            var lista = new List<Veiculo>();

            string sql = "SELECT id_Veiculo, placa, modelo FROM veiculos";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Veiculo
                {
                    Id = (int)row["id_Veiculo"],
                    Placa = row["placa"].ToString(),
                    NomeVeiculo = row["modelo"].ToString()
                });
            }

            return lista;
        }

        public void PostVeiculo(Veiculo m)
        {
            string sql = "INSERT INTO veiculos (placa, modelo) VALUES (@placa, @modelo)";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@placa", m.Placa),
                new NpgsqlParameter("@modelo", m.NomeVeiculo)
            );
        }
    }
}
