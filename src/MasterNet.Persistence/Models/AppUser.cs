using Microsoft.AspNetCore.Identity;

namespace MasterNet.Persistence.Models;

public class AppUser : IdentityUser // Cuando se convierta en una tabla, adicionalmente a lo que tiene el modelo, se añaden estas propiedades
{
    public string? NombreCompleto {get; set;}
    public string? Carrera {get; set;}
}