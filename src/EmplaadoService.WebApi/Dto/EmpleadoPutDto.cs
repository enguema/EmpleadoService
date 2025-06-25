using System.ComponentModel.DataAnnotations;
using Entities;
using MAIT.Interfaces;

namespace Dto;
public class EmpleadoPutDto : IPutDto<Empleado>
{
    //DTO: Objeto de Transferencia de Datos
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public string? Contacto { get; set; }

    public void UpdateEntity(in Empleado entity, string usuario)
    {
        //throw new NotImplementedException();
        entity.Nombre = Nombre;
        entity.Apellidos = Apellidos;
        entity.Contacto = Contacto;
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        //throw new NotImplementedException();
        if (Contacto.Length > 9) yield return new("Longitud no válida", [nameof(Contacto)]);
    }
}