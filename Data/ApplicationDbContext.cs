using Microsoft.EntityFrameworkCore;
using ApiTaller.Models;
using System.Collections.Generic;

namespace ApiTaller.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<ComentarioCliente> ComentariosClientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CompraInventario> ComprasInventario { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<HistorialMantenimiento> HistorialMantenimientos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<OrdenInventario> OrdenesInventario { get; set; }
        public DbSet<OrdenServicio> OrdenesServicios { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}
