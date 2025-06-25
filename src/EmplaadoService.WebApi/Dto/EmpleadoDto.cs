using Entities;
using MAIT.Interfaces;

namespace Dto;

public record EmpleadoDto(Guid Id, string? Nombre, string? Apellidos, string? Contacto) : IGetDto<Empleado>
{

    public static bool FromEntity<TDto>(Empleado entity, out TDto dto) where TDto : IGetDto<Empleado>
    {
        //throw new NotImplementedException();
        dto = (TDto)FromEntity(entity);
        return true;
        
    }

    public static IGetDto<Empleado> FromEntity(Empleado entity)
    {
        //throw new NotImplementedException();
        var dto= new EmpleadoDto(
            Id: entity.Id,
            Nombre: entity.Nombre,
            Apellidos: entity.Apellidos,
            Contacto: entity.Contacto
        );
        return dto;
    }
}