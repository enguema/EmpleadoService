using Microsoft.EntityFrameworkCore;
using MAIT.DataAccess;
using Entities;

namespace Persistence;
public class ServiceDbContext(DbContextOptions<ServiceDbContext> options) : EmptyDbContext(options)
{
    //EmptyDbContext: es de la libreria MAIT
    DbSet<Empleado> Empleados { get; set; }
}