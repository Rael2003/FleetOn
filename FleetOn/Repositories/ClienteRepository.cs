using FleetOn.Interfaces;
using FleetOn.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FleetOn.Repositories
{
    public class ClienteRepository:IClienteRepository
    {
        private readonly List<Cliente> _Clientes;
        public Cliente GetById(int id)
        {
            Cliente lista = new Cliente();

            string sql = "SELECT id_Cliente, nome, documento FROM clientes WHERE id_Cliente = " + id;

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Id = (int)row["id_Cliente"];
                lista.Nome = row["nome"].ToString();
                lista.Doc = row["documento"].ToString();
            }
            return lista;
        }

        public IEnumerable<Cliente> GetAll()
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

        public IEnumerable<Cliente> GetAtivos()
        {
            var lista = new List<Cliente>();

            string sql = "SELECT id_Cliente, nome, documento FROM clientes WHERE inativo = false";

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
            string sql = "INSERT INTO clientes (nome, documento, inativo) VALUES (@nome, @documento,false)";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@nome", m.Nome),
                new NpgsqlParameter("@documento", m.Doc)
            );
        }

        public void DeleteCliente(int id)
        {
            string sql = "UPDATE clientes SET inativo = true WHERE id_cliente = @id";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@id", id)
            );
        }

        public void UpdateCliente(int id, Cliente cliente)
        {
            string sql = @"UPDATE clientes SET nome = @nome, documento = @documento WHERE id_cliente = @id";

            //, telefone = @telefone, email = @email, endereco = @endereco
            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@nome", cliente.Nome),
                new NpgsqlParameter("@documento", cliente.Doc)
                //new NpgsqlParameter("@telefone", cliente.Telefone),
                //new NpgsqlParameter("@email", cliente.Email),
                //new NpgsqlParameter("@endereco", cliente.Endereco)
            );
        }
    }
}
