using ApiTaller.Config;
using ApiTaller.Data;
using ApiTaller.Repositories.Implementations;
using ApiTaller.Repositories.Interfaces;
using ApiTaller.Services.Implementations;
using ApiTaller.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTaller
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Método para configurar los servicios
        public void ConfigureServices(IServiceCollection services)
        {
            // Configuración de la base de datos (SQL Server)
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Repositorios
            services.AddScoped<ICitaRepository, CitaRepository>();
            //services.AddScoped<IClienteRepository, ClienteRepository>();
            //services.AddScoped<IComentarioClienteRepository, ComentarioClienteRepository>();
            //services.AddScoped<ICompraRepository, CompraRepository>();
            //services.AddScoped<ICompraInventarioRepository, CompraInventarioRepository>();
            //services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            //services.AddScoped<IHistorialMantenimientoRepository, HistorialMantenimientoRepository>();
            //services.AddScoped<IInventarioRepository, InventarioRepository>();
            //services.AddScoped<IOrdenRepository, OrdenRepository>();
            //services.AddScoped<IOrdenInventarioRepository, OrdenInventarioRepository>();
            //services.AddScoped<IOrdenServicioRepository, OrdenServicioRepository>();
            //services.AddScoped<IPagoRepository, PagoRepository>();
            //services.AddScoped<IProveedorRepository, ProveedorRepository>();
            //services.AddScoped<IServicioRepository, ServicioRepository>();
            //services.AddScoped<IVehiculoRepository, VehiculoRepository>();

            // Servicios
            services.AddScoped<ICitaService, CitaService>();
            //services.AddScoped<IClienteService, ClienteService>();
            //services.AddScoped<IComentarioClienteService, ComentarioClienteService>();
            //services.AddScoped<ICompraService, CompraService>();
            //services.AddScoped<ICompraInventarioService, CompraInventarioService>();
            //services.AddScoped<IEmpleadoService, EmpleadoService>();
            //services.AddScoped<IHistorialMantenimientoService, HistorialMantenimientoService>();
            //services.AddScoped<IInventarioService, InventarioService>();
            //services.AddScoped<IOrdenService, OrdenService>();
            //services.AddScoped<IOrdenInventarioService, OrdenInventarioService>();
            //services.AddScoped<IOrdenServicioService, OrdenServicioService>();
            //services.AddScoped<IPagoService, PagoService>();
            //services.AddScoped<IProveedorService, ProveedorService>();
            //services.AddScoped<IServicioService, ServicioService>();
            //services.AddScoped<IVehiculoService, VehiculoService>();

            // Configuración de controladores
            services.AddControllers();

            // Configuración de Swagger para la documentación de API
            services.AddSwaggerDocumentation();
        }

        // Método para configurar el pipeline de middleware
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Middleware para Swagger
            app.UseSwaggerDocumentation();

            // Middleware para redirección HTTPS
            app.UseHttpsRedirection();

            // Middleware de enrutamiento
            app.UseRouting();

            // Middleware de autorización
            app.UseAuthorization();

            // Mapeo de controladores
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
