namespace MasterNet.Domain;

public class Curso : BaseEntity
{
    public string? Titulo {get; set;}
    public string? Descripcion {get; set;}
    public ICollection<Clasificacion>? Calificaciones {get; set;} // Atributo que indica que un curso puede tener muchas calificaciones
    public ICollection<Precio>? Precios {get; set;}
    public ICollection<CursoPrecio>? CursoPrecios {get; set;}
    public ICollection<Instructor>? Instructores {get; set;}
    public ICollection<CursoInstructor>? CursoInstructores {get; set;}
    public ICollection<Photo>? Photos {get; set;}
}