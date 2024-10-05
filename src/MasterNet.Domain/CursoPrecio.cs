namespace MasterNet.Domain;

// Entidad de tabla intermedia entre curso y precio

public class CursoPrecio
{
    public Guid? CursoId {get; set;}
    public Curso? Curso {get; set;}
    public Guid? PrecioId {get; set;}
    public Precio? Precio {get; set;}
}