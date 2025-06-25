using Entities;
using Interfaces;
using MAIT.DataAccess;
using MAIT.Interfaces;
using Persistence;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.Configure<DbOptions>(builder.Configuration.GetSection(nameof(DbOptions)));
builder.Services.AddSingleton<IDataService, DataService<ServiceDbContext>>();
builder.Services.AddSingleton<IEmpleadoService, EmpleadoSevice>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();
app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI();


app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
