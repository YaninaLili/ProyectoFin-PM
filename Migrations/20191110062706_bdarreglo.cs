using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFin_PM.Migrations
{
    public partial class bdarreglo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tiempo",
                table: "Servicios",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Servicios",
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Medida",
                table: "Productos",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Productos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Productos");

            migrationBuilder.AlterColumn<string>(
                name: "Tiempo",
                table: "Servicios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Medida",
                table: "Productos",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
