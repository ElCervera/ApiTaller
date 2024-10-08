using Microsoft.EntityFrameworkCore;
using ApiTaller.Config;
using ApiTaller.Data;
using ApiTaller.Repositories.Implementations;
using ApiTaller.Repositories.Interfaces;
using ApiTaller.Services.Implementations;
using ApiTaller.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICitaRepository, CitaRepository>();
builder.Services.AddScoped<ICitaService, CitaService>();

// Agregar otros servicios y repositorios aqu�...

// Swagger
builder.Services.AddSwaggerDocumentation();

// Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwaggerDocumentation();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();
