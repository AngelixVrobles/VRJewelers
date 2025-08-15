using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRJewelers.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "ImagenUrl",
                value: "/Imagen/Aretesperla.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "ImagenUrl",
                value: "/Imagen/anillocompromiso.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "ImagenUrl",
                value: "/Imagen/pendientesdeoro.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "ImagenUrl",
                value: "/Imagen/anilloruby.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                column: "ImagenUrl",
                value: "/Imagen/collardiamantes.webp");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "ImagenUrl",
                value: "/Imagen/relojacero.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "ImagenUrl",
                value: "/Imagen/RelojAutomaticodelujo.webp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Cantidad", "Descripcion", "Disponible", "ITBIS", "ImagenUrl", "Nombre", "Precio", "TipoId" },
                values: new object[] { 7, 50, "Broche en forma de flor con incrustaciones de cristal.", true, 324f, "/Imagen/broche_floral.jpg", "Broche Floral", 1800f, 1 });
        }
    }
}
