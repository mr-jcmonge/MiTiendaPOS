using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiTiendaPOS.Migrations
{
    /// <inheritdoc />
    public partial class DatosDePrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Correo", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, null, "COnsumidor Final", null },
                    { 2, null, "María Lopez", "7000-0000" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[,]
                {
                    { 1, true, 1, "Soda 600ml", 0.90m, 48 },
                    { 2, true, 1, "Agua Purificada", 0.50m, 60 },
                    { 3, true, 2, "Arroz Blanco", 0.85m, 40 },
                    { 4, true, 2, "Frijol de Seda", 1.10m, 20 },
                    { 5, true, 3, "Detergente MAXI ESPUMA", 3.25m, 15 },
                    { 6, true, 3, "Lejia 1L", 1.15m, 25 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NombreUsuario", "Rol" },
                values: new object[] { 2, "cajero1", "Cajero" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
