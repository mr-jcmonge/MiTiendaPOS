using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Config;
using MiTiendaPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaPOS.Data
{
    public class MiTiendaPOSContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }

        public MiTiendaPOSContext() { }

        public MiTiendaPOSContext(DbContextOptions<MiTiendaPOSContext>options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {// reemplazamos la cadena de conexion que tenia definida anteriormente
            if (!options.IsConfigured)
            {
                options.UseSqlServer(ConfiguracionApp.ObtenerCadenaConexion());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Ventas)
                .HasForeignKey(v => v.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Usuario)
                .WithMany(u => u.Ventas)
                .HasForeignKey(v => v.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Venta)
                .WithMany(v => v.Detalles)
                .HasForeignKey(dv => dv.VentaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Producto)
                .WithMany()
                .HasForeignKey(dv => dv.ProductoId)
                .OnDelete(DeleteBehavior.Restrict);

            //AÑADIMOS DATOS SEMILLA, PARA REALIZAR LAS PRUEBAS EN LA TABLA "CATEGORIA" Y "USUARIO"
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nombre = "Bebidas" },
                new Categoria { Id = 2, Nombre = "Abarrotes" },
                new Categoria { Id = 3, Nombre = "Limpieza" });

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, NombreUsuario = "amin", Rol = "Administrador" });

            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Nombre = "Soda 600ml", CategoriaId=1,
                PrecioUnitario=0.90m, Stock=48, Activo=true},
                new Producto
                {
                    Id = 2,
                    Nombre = "Agua Purificada",
                    CategoriaId = 1,
                    PrecioUnitario = 0.50m,
                    Stock = 60,
                    Activo = true
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Arroz Blanco",
                    CategoriaId = 2,
                    PrecioUnitario = 0.85m,
                    Stock = 40,
                    Activo = true
                },
                new Producto
                {
                    Id = 4,
                    Nombre = "Frijol de Seda",
                    CategoriaId = 2,
                    PrecioUnitario = 1.10m,
                    Stock = 20,
                    Activo = true
                },
                new Producto
                {
                    Id = 5,
                    Nombre = "Detergente MAXI ESPUMA",
                    CategoriaId = 3,
                    PrecioUnitario = 3.25m,
                    Stock = 15,
                    Activo = true
                }, new Producto
                {
                    Id = 6,
                    Nombre = "Lejia 1L",
                    CategoriaId = 3,
                    PrecioUnitario = 1.15m,
                    Stock = 25,
                    Activo = true
                }
                );
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nombre = "COnsumidor Final" },
                new Cliente { Id = 2, Nombre = "María Lopez", Telefono = "7000-0000" });
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id=2, NombreUsuario="cajero1", Rol="Cajero"});
        }
    }
}
