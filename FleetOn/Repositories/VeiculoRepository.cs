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
        public Veiculo GetById(int id)
        {
            Veiculo lista = new Veiculo();

            string sql = "SELECT id_Veiculo, modelo, placa FROM Veiculos WHERE id_Veiculo = " + id;

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Id = (int)row["id_Veiculo"];
                lista.Placa = row["placa"].ToString();
                lista.NomeVeiculo = row["modelo"].ToString();
            }
            return lista;
        }
        public IEnumerable<Veiculo> GetAtivos()
        {
            var lista = new List<Veiculo>();

            string sql = "SELECT id_Veiculo, placa, modelo FROM veiculos where inativo = false";

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
            string sql = "INSERT INTO veiculos (placa, modelo, inativo) VALUES (@placa, @modelo, false)";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@placa", m.Placa),
                new NpgsqlParameter("@modelo", m.NomeVeiculo)
            );
        }

        public void DeleteVeiculo(int id)
        {
            string sql = "UPDATE Veiculos SET inativo = true WHERE id_Veiculo = @id";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@id", id)
            );
        }
        public void UpdateVeiculo(int id, Veiculo Veiculo)
        {
            string sql = @"UPDATE Veiculos SET modelo = @modelo, placa = @placa WHERE id_Veiculo = @id";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@modelo", Veiculo.NomeVeiculo),
                new NpgsqlParameter("@placa", Veiculo.Placa)
            );
        }
    }
}
