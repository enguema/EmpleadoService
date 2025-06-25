using System.ComponentModel.DataAnnotations;
using Entities;

using MAIT.Interfaces;
namespace Dto;
public class EmpleadoPostDto: IPostDto<Empleado>
{
    //DTO: Objeto de Transferencia de Datos
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public string? Contacto { get; set; }

    public bool ToEntity(string usuario, out Empleado entity, Guid? id = null)
    {
        //throw new NotImplementedException();
        entity = ToEntity(usuario, id);
        return true;
    }

    public Empleado ToEntity(string usuario, Guid? id = null)
    {
        //throw new NotImplementedException();
         return new Empleado
        {
            Nombre = Nombre,
            Apellidos = Apellidos,
            Contacto=Contacto
        };
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        //throw new NotImplementedException();
        if(Nombre.Length<2) yield return new("Longitud no valida", [nameof(Nombre)]);
    }
}