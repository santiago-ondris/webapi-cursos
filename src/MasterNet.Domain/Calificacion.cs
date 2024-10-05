namespace MasterNet.Domain;

public class Clasificacion : BaseEntity
{
    public string? Alumno {get; set;}
    public int Puntaje {get; set;}
    public string? Comentario {get;set;}  
    public Guid CursoId {get; set;} // Clave foranea que representa al curso al que aplica.
    public Curso? Curso {get; set;} // Cada atributo foraneo debe ir acompañado por su representacion del objeto (curso en este caso)
}