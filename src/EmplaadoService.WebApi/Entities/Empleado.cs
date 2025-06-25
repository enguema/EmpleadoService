using MAIT.Interfaces;

namespace Entities;
public class Empleado: BaseEntity
{
    //Siempre heredan de baseEntity
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public string? Contacto { get; set; }
}