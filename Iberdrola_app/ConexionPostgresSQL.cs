using Npgsql;
using System;
using System.Data;

public class ConexionPostgresSQL
{
    private NpgsqlConnection connection;
    private string connectionString;

    public ConexionPostgresSQL()
    {
        // Configura la cadena de conexión a la base de datos
        connectionString = "Host=localhost;Username=postgres;Password=123456;Database=Iberdrola";
        connection = new NpgsqlConnection(connectionString);
    }

    public async Task OpenConnectionAsync()
    {
        // Abre la conexión de manera asincrónica
        await connection.OpenAsync();
    }

    public async Task CloseConnectionAsync()
    {
        // Cierra la conexión de manera asincrónica
        await connection.CloseAsync();
    }

    public async Task InsertDataAsync(string someFieldData)
    {
        try
        {
            await OpenConnectionAsync();

            // Inserta datos en la base de datos
            using (var cmd = new NpgsqlCommand("INSERT INTO data (some_field) VALUES (@p)", connection))
            {
                cmd.Parameters.AddWithValue("p", someFieldData);
                await cmd.ExecuteNonQueryAsync();
            }
        }
        finally
        {
            await CloseConnectionAsync();
        }
    }

    public async Task<IEnumerable<string>> ObtenerTodosLosUsuariosAsync()
    {
        List<string> usuarios = new List<string>();

        try
        {
            await OpenConnectionAsync();

            // Recupera todos los usuarios de la base de datos
            using (var cmd = new NpgsqlCommand("SELECT * FROM Cliente", connection))
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    usuarios.Add(reader.GetString(0)); // Ajusta esto según la estructura de tu tabla
                }
            }
        }
        finally
        {
            await CloseConnectionAsync();
        }

        return usuarios;
    }

}
