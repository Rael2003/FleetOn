using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Npgsql;

public static class PostgresHelper
{
    private static string GetConnString()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // diretório do exe
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration config = builder.Build();
        return config.GetConnectionString("DefaultConnection");
    }

    public static NpgsqlConnection GetOpenConnection()
    {
        var conn = new NpgsqlConnection(GetConnString());
        conn.Open();
        return conn;
    }

    public static async Task<NpgsqlConnection> GetOpenConnectionAsync()
    {
        var conn = new NpgsqlConnection(GetConnString());
        await conn.OpenAsync().ConfigureAwait(false);
        return conn;
    }

    public static object ExecuteScalar(string sql, params NpgsqlParameter[] parameters)
    {
        using (var conn = GetOpenConnection())
        using (var cmd = new NpgsqlCommand(sql, conn))
        {
            if (parameters != null && parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);

            return cmd.ExecuteScalar();
        }
    }

    public static DataTable GetDataTable(string sql, params NpgsqlParameter[] parameters)
    {
        using (var conn = GetOpenConnection())
        using (var da = new NpgsqlDataAdapter(sql, conn))
        {
            if (parameters != null && parameters.Length > 0)
                da.SelectCommand.Parameters.AddRange(parameters);

            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
