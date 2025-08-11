using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRJewelers.Migrations
{
    /// <inheritdoc />
    public partial class Destacados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "ImagenUrl",
                value: "/Imagen/Anillo18K.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "ImagenUrl",
                value: "/Imagen/Salvatoreplata.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "ImagenUrl",
                value: "/imagen/PulseDiamantes.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "ImagenUrl",
                value: "/Imagen/aretes_perla.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "ImagenUrl",
                value: "/Imagen/anillo_compromiso.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "ImagenUrl",
                value: "/Imagen/gargantilla_zafiro.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "ImagenUrl",
                value: "/Imagen/broche_floral.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "ImagenUrl",
                value: "/Imagen/pendientes_oro.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "ImagenUrl",
                value: "/Imagen/anillo_rubi.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                column: "ImagenUrl",
                value: "/Imagen/collar_diamantes.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "ImagenUrl",
                value: "/Imagen/reloj_acero.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "ImagenUrl",
                value: "/Imagen/reloj_lujo.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "ImagenUrl",
                value: "/images/anillo_oro.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "ImagenUrl",
                value: "/images/collar_plata.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "ImagenUrl",
                value: "/images/pulsera_diamantes.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "ImagenUrl",
                value: "/images/aretes_perla.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "ImagenUrl",
                value: "/images/anillo_compromiso.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "ImagenUrl",
                value: "/images/gargantilla_zafiro.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "ImagenUrl",
                value: "/images/broche_floral.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "ImagenUrl",
                value: "/images/pendientes_oro.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "ImagenUrl",
                value: "/images/anillo_rubi.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                column: "ImagenUrl",
                value: "/images/collar_diamantes.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "ImagenUrl",
                value: "/images/reloj_acero.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "ImagenUrl",
                value: "/images/reloj_lujo.jpg");
        }
    }
}
