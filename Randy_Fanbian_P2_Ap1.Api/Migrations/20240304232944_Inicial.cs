using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Randy_Fanbian_P2_Ap1.Api.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accesorios",
                columns: table => new
                {
                    AccesorioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesorios", x => x.AccesorioId);
                });

            migrationBuilder.CreateTable(
                name: "VehiculoDetalle",
                columns: table => new
                {
                    VehiculoDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    AccesorioId = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorId = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoDetalle", x => x.VehiculoDetalleId);
                    table.ForeignKey(
                        name: "FK_VehiculoDetalle_Accesorios_AccesorioId",
                        column: x => x.AccesorioId,
                        principalTable: "Accesorios",
                        principalColumn: "AccesorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accesorios",
                columns: new[] { "AccesorioId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Camara Tracera" },
                    { 2, "Pantalla interior" },
                    { 3, "Interior en piel" },
                    { 4, "Sun Roof" },
                    { 5, "Aros de lujo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoDetalle_AccesorioId",
                table: "VehiculoDetalle",
                column: "AccesorioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehiculoDetalle");

            migrationBuilder.DropTable(
                name: "Accesorios");
        }
    }
}
