using FleetOn.Interfaces;
using FleetOn.Models;
using FleetOn.Services;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOn.Repositories
{
    public class ViagemRepository:IViagemRepository
    {
        private readonly List<Viagem> _Viagem;
        private readonly ClienteService _Clientes;
        private readonly MotoristaService _Motorista;
        public Viagem GetById(int id)
        {
            return _Viagem.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Viagem> GetAll()
        {
            var lista = new List<Viagem>();

            string sql = "SELECT id_viagem, id_cliente, id_motorista FROM Viagens";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Viagem
                {
                    Id = (int)row["id_Viagem"],
                    cliente = _Clientes.BuscarPorId((int)row["id_cliente"]),
                    motorista = _Motorista.BuscarPorId((int)row["id_motorista"])
                });
            }

            return lista;
        }

        public IEnumerable<Viagem> GetAtivos()
        {
            var lista = new List<Viagem>();

            string sql = "SELECT id_viagem, id_cliente, id_motorista FROM Viagens";

            var dt = PostgresHelper.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Viagem
                {
                    Id = (int)row["id_Viagem"],
                    cliente = _Clientes.BuscarPorId((int)row["id_cliente"]),
                    motorista = _Motorista.BuscarPorId((int)row["id_motorista"])
                });
            }

            return lista;
        }

        public void PostViagem(Viagem m)
        {
            string sql = "INSERT INTO viagens (id_cliente, id_motorista) VALUES (@id_cliente, @id_motorista)";

            PostgresHelper.ExecuteScalar(sql,
                new NpgsqlParameter("@id_cliente", m.cliente.Id),
                new NpgsqlParameter("@id_motorista", m.motorista.Id)
            );
        }
    }
}
