using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRJewelers.Migrations
{
    /// <inheritdoc />
    public partial class newColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ITBIS",
                table: "Productos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "ITBIS",
                table: "Productos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 855f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 576f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 2160f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 504f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 1710f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 1566f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 630f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 1224f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 2700f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 936f });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                columns: new[] { "Disponible", "ITBIS" },
                values: new object[] { true, 2844f });
        }
    }
}
