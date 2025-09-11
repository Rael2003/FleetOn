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
    public class ClienteRepository:IClienteRepository
    {
        private readonly List<Cliente> _Clientes;
        public Cliente GetById(int id)
        {
            return _Clientes.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            var lista = new List<Cliente>();

            string sql = "SELECT id_Cliente, nome, cnh FROM clientes";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Cliente
                {
                    Id = (int)row["id_Cliente"],
                    Nome = row["nome"].ToString(),
                    Doc = row["documento"].ToString()
                });
            }

            return lista;
        }

        public IEnumerable<Cliente> GetAtivos()
        {
            var lista = new List<Cliente>();

            string sql = "SELECT id_Cliente, nome, documento FROM clientes";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Cliente
                {
                    Id = (int)row["id_Cliente"],
                    Nome = row["nome"].ToString(),
                    Doc = row["documento"].ToString()
                });
            }

            return lista;
        }

        public void PostCliente(Cliente m)
        {
            string sql = "INSERT INTO clientes (nome, documento) VALUES (@nome, @documento)";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@nome", m.Nome),
                new NpgsqlParameter("@documento", m.Doc)
            );
        }
    }
}
