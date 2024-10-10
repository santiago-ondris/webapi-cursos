using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionSeguridad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("3f155481-b306-43b4-b736-895f7ee6c9a5"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("48921a25-3f1d-481f-8a1f-273b8daab147"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("5a98f06c-ae8d-4833-9e42-b87d602c10cc"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("741967eb-a8d7-4b47-b6e0-a0d45faa41c6"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("8212bf7c-b780-402a-b83a-aa0681167850"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("863a47c6-cd03-4354-a942-95e790e829f3"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a2f76e43-94ff-4312-9b93-7b6a51c36fe2"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b71b87df-3818-48f0-a9ce-0d76b2ffb00e"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b9a5d754-6e81-4d07-ad67-07375c42144f"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("23316153-9319-46fc-9c3d-0c5b7478499e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("4fab5457-f6cd-42cb-a8e6-78eaa0e405d3"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("6fe87960-a4d1-44ef-8fdb-d2efb955dcfd"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("7fea54f2-f928-4440-b5ad-6983b5d59a11"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("8eb560d4-f6be-44af-825a-448acdd5d1ae"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("8ef350e1-ba53-4bea-9b90-6996fef49c88"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ae2d20c9-a615-4757-87c7-f30e62935d0b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("d99be180-cdd9-481e-a2d0-5adcbc0886fc"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e2c875f7-ff66-4850-a5b9-e4338636f53e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("f3f3451b-8194-40f7-929a-45517bd987f9"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("abd57bfc-e93f-4e3c-9d62-8a34eca3c193"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    NombreCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    Carrera = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27f5efa1-a70c-4029-a383-af280334b6ca", null, "CLIENT", "CLIENT" },
                    { "e7737264-30a3-4ac2-9044-7e843e501c57", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("1babafa4-a44d-4b1d-aca0-0f33df26fdb5"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(4056), "Intelligent Granite Tuna" },
                    { new Guid("21d1504e-3cfc-4801-a1c9-fcb8e50228ab"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3879), "Intelligent Rubber Hat" },
                    { new Guid("23706472-d6b8-4f35-8f06-53c6e9810855"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3922), "Fantastic Metal Hat" },
                    { new Guid("618222a1-9c44-408d-a183-37470e107b3e"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(4148), "Intelligent Plastic Mouse" },
                    { new Guid("7c75e3dd-1565-43a3-ba8d-c185949ea648"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3967), "Gorgeous Concrete Computer" },
                    { new Guid("b0b23293-2b3a-434c-b8d4-16ffec6f4bc0"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(4013), "Handmade Cotton Shirt" },
                    { new Guid("c90b1259-ccbe-42d9-9e80-f0c16c335841"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3821), "Rustic Plastic Chips" },
                    { new Guid("eabd484f-f816-411a-bcef-3cb3d3f54123"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(4099), "Small Metal Keyboard" },
                    { new Guid("edd65d29-27aa-4e2e-b385-1a096770716d"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3762), "Tasty Frozen Pizza" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("125cd795-9bd6-46ec-8f2b-203bf9a0cde7"), "Schultz", "National Metrics Consultant", "Kobe" },
                    { new Guid("190f9e81-55a0-47b6-8fed-e16f60b48306"), "Walker", "Central Markets Strategist", "Darian" },
                    { new Guid("2a074c62-f4ca-4919-b41f-aaede34a2a6f"), "Rodriguez", "Regional Program Designer", "Kip" },
                    { new Guid("3662dabb-5926-45d5-a7be-69143caa0c52"), "Kuhn", "Customer Solutions Strategist", "Nayeli" },
                    { new Guid("5dd7d6af-92d1-4a3c-b78b-670c061a22ea"), "Roob", "Internal Marketing Designer", "Angelo" },
                    { new Guid("5e02e426-6ce1-401b-ae5f-d6510daae6d0"), "Hauck", "Chief Branding Officer", "Omer" },
                    { new Guid("86c2d0c2-d98e-46f1-bb6e-3c11f9ca0f1b"), "Ondricka", "Human Branding Planner", "Madonna" },
                    { new Guid("97cb265e-99d2-43b0-8d54-2ec2a4e46be4"), "Ankunding", "Corporate Accountability Designer", "Loyal" },
                    { new Guid("a9cd61bb-cca4-4ffb-ace4-53911ecabfb7"), "Wilkinson", "Principal Accounts Orchestrator", "Queenie" },
                    { new Guid("e9895f7a-5862-44f6-b2e8-717e5f8eb29c"), "Spinka", "Human Program Agent", "Ettie" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("3ae00121-bac7-45c3-b8c5-9cfefe70c62e"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 2, "POLICIES", "CURSO_UPDATE", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 3, "POLICIES", "CURSO_WRITE", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 4, "POLICIES", "CURSO_DELETE", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 8, "POLICIES", "COMENTARIO_CREATE", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 10, "POLICIES", "COMENTARIO_READ", "e7737264-30a3-4ac2-9044-7e843e501c57" },
                    { 11, "POLICIES", "CURSO_READ", "27f5efa1-a70c-4029-a383-af280334b6ca" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "27f5efa1-a70c-4029-a383-af280334b6ca" },
                    { 13, "POLICIES", "COMENTARIO_READ", "27f5efa1-a70c-4029-a383-af280334b6ca" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "27f5efa1-a70c-4029-a383-af280334b6ca" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("1babafa4-a44d-4b1d-aca0-0f33df26fdb5"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("21d1504e-3cfc-4801-a1c9-fcb8e50228ab"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("23706472-d6b8-4f35-8f06-53c6e9810855"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("618222a1-9c44-408d-a183-37470e107b3e"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("7c75e3dd-1565-43a3-ba8d-c185949ea648"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b0b23293-2b3a-434c-b8d4-16ffec6f4bc0"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("c90b1259-ccbe-42d9-9e80-f0c16c335841"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("eabd484f-f816-411a-bcef-3cb3d3f54123"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("edd65d29-27aa-4e2e-b385-1a096770716d"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("125cd795-9bd6-46ec-8f2b-203bf9a0cde7"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("190f9e81-55a0-47b6-8fed-e16f60b48306"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("2a074c62-f4ca-4919-b41f-aaede34a2a6f"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3662dabb-5926-45d5-a7be-69143caa0c52"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("5dd7d6af-92d1-4a3c-b78b-670c061a22ea"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("5e02e426-6ce1-401b-ae5f-d6510daae6d0"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("86c2d0c2-d98e-46f1-bb6e-3c11f9ca0f1b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("97cb265e-99d2-43b0-8d54-2ec2a4e46be4"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("a9cd61bb-cca4-4ffb-ace4-53911ecabfb7"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e9895f7a-5862-44f6-b2e8-717e5f8eb29c"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("3ae00121-bac7-45c3-b8c5-9cfefe70c62e"));

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
        }
    }
}
