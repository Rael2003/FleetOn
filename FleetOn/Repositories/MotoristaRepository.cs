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
            return _motoristas.FirstOrDefault(m => m.Id == id);
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

            string sql = "SELECT id_motorista, nome, cnh FROM motoristas where disponibilidade = true";

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
            string sql = "INSERT INTO motoristas (nome, cnh, categoria_cnh) VALUES (@nome, @cnh, @categoria_cnh)";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@nome", m.Nome),
                new NpgsqlParameter("@cnh", m.Cnh),
                new NpgsqlParameter("@categoria_cnh", m.Categoria_cnh)
            );
        }
    }
}
