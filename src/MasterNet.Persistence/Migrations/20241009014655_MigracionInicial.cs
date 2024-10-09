using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Grado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    PrecioActual = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    PrecioPromocion = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "calificaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Alumno = table.Column<string>(type: "TEXT", nullable: true),
                    Puntaje = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calificaciones_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagenes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagenes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_instructores",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_instructores", x => new { x.InstructorId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_instructores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_instructores_instructores_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_precios",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrecioId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_precios", x => new { x.PrecioId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_precios_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_precios_precios_PrecioId",
                        column: x => x.PrecioId,
                        principalTable: "precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("3f155481-b306-43b4-b736-895f7ee6c9a5"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4998), "Licensed Wooden Tuna" },
                    { new Guid("48921a25-3f1d-481f-8a1f-273b8daab147"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4859), "Incredible Wooden Car" },
                    { new Guid("5a98f06c-ae8d-4833-9e42-b87d602c10cc"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4717), "Small Soft Tuna" },
                    { new Guid("741967eb-a8d7-4b47-b6e0-a0d45faa41c6"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4797), "Refined Steel Pizza" },
                    { new Guid("8212bf7c-b780-402a-b83a-aa0681167850"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4921), "Licensed Granite Towels" },
                    { new Guid("863a47c6-cd03-4354-a942-95e790e829f3"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4759), "Tasty Concrete Gloves" },
                    { new Guid("a2f76e43-94ff-4312-9b93-7b6a51c36fe2"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4893), "Handmade Rubber Shoes" },
                    { new Guid("b71b87df-3818-48f0-a9ce-0d76b2ffb00e"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4951), "Handmade Wooden Computer" },
                    { new Guid("b9a5d754-6e81-4d07-ad67-07375c42144f"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 10, 9, 1, 46, 54, 753, DateTimeKind.Utc).AddTicks(4829), "Licensed Wooden Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("23316153-9319-46fc-9c3d-0c5b7478499e"), "Considine", "Dynamic Factors Administrator", "Jaydon" },
                    { new Guid("4fab5457-f6cd-42cb-a8e6-78eaa0e405d3"), "Bechtelar", "Future Data Manager", "Arielle" },
                    { new Guid("6fe87960-a4d1-44ef-8fdb-d2efb955dcfd"), "Adams", "Direct Configuration Manager", "Braulio" },
                    { new Guid("7fea54f2-f928-4440-b5ad-6983b5d59a11"), "Lowe", "Corporate Accounts Strategist", "Stephen" },
                    { new Guid("8eb560d4-f6be-44af-825a-448acdd5d1ae"), "Gottlieb", "Forward Communications Liaison", "Levi" },
                    { new Guid("8ef350e1-ba53-4bea-9b90-6996fef49c88"), "Muller", "Regional Web Developer", "Kaelyn" },
                    { new Guid("ae2d20c9-a615-4757-87c7-f30e62935d0b"), "Bailey", "Direct Applications Director", "Winona" },
                    { new Guid("d99be180-cdd9-481e-a2d0-5adcbc0886fc"), "Schaefer", "National Marketing Orchestrator", "Elisha" },
                    { new Guid("e2c875f7-ff66-4850-a5b9-e4338636f53e"), "Wunsch", "Lead Response Liaison", "Rahsaan" },
                    { new Guid("f3f3451b-8194-40f7-929a-45517bd987f9"), "Gislason", "Legacy Applications Coordinator", "Lonie" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("abd57bfc-e93f-4e3c-9d62-8a34eca3c193"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificaciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_instructores_CursoId",
                table: "cursos_instructores",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_precios_CursoId",
                table: "cursos_precios",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_imagenes_CursoId",
                table: "imagenes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
