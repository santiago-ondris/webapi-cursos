using Bogus;
using MasterNet.Domain;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Persistence;

public class MasterNetDbContext : DbContext
{
    public DbSet<Curso> Cursos {get; set;}
    public DbSet<Instructor> Instructores {get; set;}
    public DbSet<Precio> Precios {get; set;}
    public DbSet<Calificacion> Calificaciones {get; set;}

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

    //Este metodo es para crear las tablas y sus relaciones
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Curso>().ToTable("cursos"); // Representa el modelo, la conjuncion entre la entidad y la sesion de entity framework
        modelBuilder.Entity<Instructor>().ToTable("instructores"); // La declaracion de las tablas suele ser en minusculas plural
        modelBuilder.Entity<CursoInstructor>().ToTable("cursos_instructores");
        modelBuilder.Entity<Precio>().ToTable("precios");
        modelBuilder.Entity<CursoPrecio>().ToTable("cursos_precios");
        modelBuilder.Entity<Calificacion>().ToTable("calificaciones");
        modelBuilder.Entity<Photo>().ToTable("imagenes");

        modelBuilder.Entity<Precio>() // Cuando se genere la tabla precio, va a ser un valor decimal con 10 enteros y 2 valores decimales
            .Property(b => b.PrecioActual)
            .HasPrecision(10,2);

        modelBuilder.Entity<Precio>() // Cuando se genere la tabla precio, va a ser un valor decimal con 10 enteros y 2 valores decimales
            .Property(b => b.PrecioPromocion)
            .HasPrecision(10,2);    

        modelBuilder.Entity<Precio>() // Entity framework por defecto establece un string en un varchar, este seria el codigo para hacerlo mas preciso
            .Property(b => b.Nombre)
            .HasColumnType("VARCHAR")
            .HasMaxLength(250);    

        //Relaciones entre los modelos    
        modelBuilder.Entity<Curso>()
            .HasMany(m => m.Photos) // Un curso contiene muchas fotos
            .WithOne(m => m.Curso) // Cada foto tiene un curso
            .HasForeignKey(m => m.CursoId) // Tiene clave foranea, CursoId
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade); // Si borro el curso, quiero que se borren tambien las imagenes relacionadas

        modelBuilder.Entity<Curso>()
            .HasMany(m => m.Calificaciones)
            .WithOne(m => m.Curso)
            .HasForeignKey(m => m.CursoId)
            .OnDelete(DeleteBehavior.Restrict); /* Se mantienen las calificaciones por mas que se borre el curso; por eso no es requerido
                queda la calificacion sin un curso relacionado */

        modelBuilder.Entity<Curso>() // Modelo de tabla intermedia para establecer la relacion muchos a muchos
            .HasMany(m => m.Precios)
            .WithMany(m => m.Cursos)
            .UsingEntity<CursoPrecio>(
                j => j
                    .HasOne(p => p.Precio)
                    .WithMany(p => p.CursoPrecios)
                    .HasForeignKey(p => p.PrecioId), // Definicion de clave foranea 
                j => j
                    .HasOne(p => p.Curso)
                    .WithMany(p => p.CursoPrecios)
                    .HasForeignKey(p => p.CursoId), // Definicion de claves foranea    
                j =>
                {
                    j.HasKey(t => new {t.PrecioId, t.CursoId}); // Definicion de claves primarias
                }    
            );

        modelBuilder.Entity<Curso>() // Modelo de tabla intermedia para establecer la relacion muchos a muchos
            .HasMany(m => m.Instructores)
            .WithMany(m => m.Cursos)
            .UsingEntity<CursoInstructor>(
                j => j
                    .HasOne(p => p.Instructor)
                    .WithMany(p => p.CursoInstructores)
                    .HasForeignKey(p => p.InstructorId), // Definicion de clave foranea 
                j => j
                    .HasOne(p => p.Curso)
                    .WithMany(p => p.CursoInstructores)
                    .HasForeignKey(p => p.CursoId), // Definicion de claves foranea    
                j =>
                {
                    j.HasKey(t => new {t.InstructorId, t.CursoId}); // Definicion de claves primarias
                }    
            );    

            // Logica para cargar la data de prueba
            modelBuilder.Entity<Curso>().HasData(DataMaster().Item1);
            modelBuilder.Entity<Precio>().HasData(DataMaster().Item2);
            modelBuilder.Entity<Instructor>().HasData(DataMaster().Item3);
    }

    // Este metodo es para generar la data de prueba consumiendo Bogus
    public Tuple<Curso[], Precio[], Instructor[]> DataMaster()
    {
        var cursos = new List<Curso>();
        var faker = new Faker();

        for(var i = 1; i < 10; i++)
        {
            var cursoId = Guid.NewGuid();
            cursos.Add(new Curso {
                Id = cursoId,
                Descripcion = faker.Commerce.ProductDescription(),
                Titulo = faker.Commerce.ProductName(),
                FechaPublicacion = DateTime.UtcNow
            });
        }

        var precioId = Guid.NewGuid();
        var precio = new Precio
        {
            Id = precioId,
            PrecioActual = 10.0m,
            PrecioPromocion = 8.0m,
            Nombre = "Precio Regular"
        };
        var precios = new List<Precio>{precio};

        var fakerInstructor = new Faker<Instructor>()
            .RuleFor(t => t.Id, _ => Guid.NewGuid())
            .RuleFor(t => t.Nombre, f => f.Name.FirstName())
            .RuleFor(t => t.Apellidos, f => f.Name.LastName())
            .RuleFor(t => t.Grado, f => f.Name.JobTitle());

        var instructores = fakerInstructor.Generate(10);

        return Tuple.Create(cursos.ToArray(), precios.ToArray(), instructores.ToArray());    
    }
}