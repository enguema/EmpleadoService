using Entities;
using Interfaces;
using MAIT.Interfaces;
using MAIT.Services;

namespace Service;

public class EmpleadoSevice
(
    IDataService dtService,
    ILogger<EmpleadoSevice> logger
): BaseCrudService<EmpleadoSevice, Empleado>(logger, dtService), IEmpleadoService;