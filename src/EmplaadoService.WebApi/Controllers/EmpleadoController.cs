using Dto;
using Entities;
using Interfaces;
using MAIT.Interfaces;
using MAIT.Services;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[Route("[controller]")]
[ApiController]
public class EmpleadoController
(
    IEmpleadoService empleadoService,
    ILogger<EmpleadoController> logger
): ApiCrudControllerBase<Empleado, EmpleadoPostDto, EmpleadoPutDto, EmpleadoDto>(empleadoService, logger);