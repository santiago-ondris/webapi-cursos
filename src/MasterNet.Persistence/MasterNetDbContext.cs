using Microsoft.EntityFrameworkCore;

namespace MasterNet.Persistence;

public class MasterNetDbContext : DbContext
{
    // Este metodo es para la cadena de conexion
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=LocalDatabase.db")
        .LogTo(
            Console.WriteLine,
            new [] {DbLoggerCategory.Database.Command.Name},
            Microsoft.Extensions.Logging.LogLevel.Information
        ).EnableSensitiveDataLogging();
        /* Con el LogTo se van a imprimir en la consola todas las transacciones
        que haga en la base de datos */
    }
}