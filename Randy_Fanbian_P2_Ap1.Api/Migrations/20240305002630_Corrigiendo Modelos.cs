using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Randy_Fanbian_P2_Ap1.Api.Migrations
{
    /// <inheritdoc />
    public partial class CorrigiendoModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorId",
                table: "VehiculoDetalle",
                newName: "Valor");

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Costo = table.Column<decimal>(type: "TEXT", nullable: false),
                    Gasto = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.VehiculoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoDetalle_VehiculoId",
                table: "VehiculoDetalle",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculoDetalle_Vehiculo_VehiculoId",
                table: "VehiculoDetalle",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiculoDetalle_Vehiculo_VehiculoId",
                table: "VehiculoDetalle");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_VehiculoDetalle_VehiculoId",
                table: "VehiculoDetalle");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "VehiculoDetalle",
                newName: "ValorId");
        }
    }
}
