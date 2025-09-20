using FleetOn.Forms;
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
    public class MotoristaRepository : IMotoristaRepository
    {
        private readonly List<Motorista> _motoristas;

        public Motorista GetById(int id)
        {
            Motorista lista = new Motorista();

            string sql = "SELECT id_Motorista, nome, cnh, categoria_cnh FROM Motoristas WHERE id_Motorista = " + id;

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Id = (int)row["id_Motorista"];
                lista.Nome = row["nome"].ToString();
                lista.Cnh = row["cnh"].ToString();
                lista.Categoria_cnh = row["categoria_cnh"].ToString();
            }
            return lista;
        }

        public IEnumerable<Motorista> GetAll()
        {
            var lista = new List<Motorista>();

            string sql = "SELECT id_motorista, nome, cnh FROM motoristas";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Motorista
                {
                    Id = (int)row["id_motorista"],
                    Nome = row["nome"].ToString(),
                    Cnh = row["cnh"].ToString()
                });
            }

            return lista;
        }

        public IEnumerable<Motorista> GetAtivos()
        {
            var lista = new List<Motorista>();

            string sql = "SELECT id_motorista, nome, cnh FROM motoristas where inativo = false";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Motorista
                {
                    Id = (int)row["id_motorista"],
                    Nome = row["nome"].ToString(),
                    Cnh = row["cnh"].ToString()
                });
            }

            return lista;
        }

        public void PostMotorista(Motorista m)
        {
            string sql = "INSERT INTO motoristas (nome, cnh, categoria_cnh, inativo) VALUES (@nome, @cnh, @categoria_cnh, false)";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@nome", m.Nome),
                new NpgsqlParameter("@cnh", m.Cnh),
                new NpgsqlParameter("@categoria_cnh", m.Categoria_cnh)
            );
        }
        public void DeleteMotorista(int id)
        {
            string sql = "UPDATE Motoristas SET inativo = true WHERE id_motorista = @id";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@id", id)
            );
        }
        public void UpdateMotorista(int id, Motorista motorista)
        {
            string sql = @"UPDATE Motoristas SET nome = @nome, cnh = @cnh, categoria_cnh = @categoria_cnh WHERE id_Motorista = @id";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@nome", motorista.Nome),
                new NpgsqlParameter("@cnh", motorista.Cnh),
                new NpgsqlParameter("@categoria_cnh", motorista.Categoria_cnh)
            );
        }
    }
}
