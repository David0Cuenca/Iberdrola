using Npgsql;
using System;
using System.Data;

public class ConexionPostgresSQL
{
    private NpgsqlDataSource dataSource;

    public ConexionPostgresSQL()
    {
        // Configuración de la conexión a la base de datos PostgreSQL
        var connectionString = "Host=localhost;Username=postgres;Password=123456;Database=Iberdrola";
        dataSource = NpgsqlDataSource.Create(connectionString);
    }

    public async Task<DataTable> ObtenerUsuariosAsync()
    {
        DataTable dataTable = new DataTable();

        try
        {
            await using var connection = await dataSource.OpenConnectionAsync();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Cliente";
            await using var reader = await command.ExecuteReaderAsync();
            dataTable.Load(reader);
        }
        catch (Exception ex)
        {
            // Manejo de excepciones
            Console.WriteLine(ex.Message);
        }

        return dataTable;
    }

    public async Task<DataTable> ObtenerClientesActivosAsync()
    {
        DataTable dataTable = new DataTable();

        try
        {
            await using var connection = await dataSource.OpenConnectionAsync();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Cliente_Activo";
            await using var reader = await command.ExecuteReaderAsync();
            dataTable.Load(reader);
        }
        catch (Exception ex)
        {
            // Manejo de excepciones
            Console.WriteLine(ex.Message);
        }

        return dataTable;
    }

    public async Task<DataTable> ObtenerContratosAsync()
    {
        DataTable dataTable = new DataTable();

        try
        {
            await using var connection = await dataSource.OpenConnectionAsync();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Contrato";
            await using var reader = await command.ExecuteReaderAsync();
            dataTable.Load(reader);
        }
        catch (Exception ex)
        {
            // Manejo de excepciones
            Console.WriteLine(ex.Message);
        }

        return dataTable;
    }

    public async Task<DataTable> ObtenerFacturasAsync()
    {
        DataTable dataTable = new DataTable();

        try
        {
            await using var connection = await dataSource.OpenConnectionAsync();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Facturas";
            await using var reader = await command.ExecuteReaderAsync();
            dataTable.Load(reader);
        }
        catch (Exception ex)
        {
            // Manejo de excepciones
            Console.WriteLine(ex.Message);
        }

        return dataTable;
    }
}
