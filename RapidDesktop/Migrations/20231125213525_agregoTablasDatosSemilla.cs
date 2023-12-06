using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RapidDesktop.Migrations
{
    /// <inheritdoc />
    public partial class agregoTablasDatosSemilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabricantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teléfono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rubros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinciaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidades_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GarantiaFabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RubroId = table.Column<int>(type: "int", nullable: true),
                    ProveedorId = table.Column<int>(type: "int", nullable: true),
                    FabricanteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Fabricantes_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricantes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Productos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Productos_Rubros_RubroId",
                        column: x => x.RubroId,
                        principalTable: "Rubros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApellidoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dirección = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teléfono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "ApellidoNombre", "Dirección", "Email", "LocalidadId", "Teléfono" },
                values: new object[,]
                {
                    { 1, "Mamadera Roberto", "Maipú 2255", "robertomam@gmail.com", null, "1563554" },
                    { 2, "Catrasca Dalmiro", "Corrientes 1698", "catradalmiro@gmail.com", null, "15569753" },
                    { 3, "Tandarika José Luis", "3 de Febrero 986", "tandajoseluis@gmail.com", null, "1541122" }
                });

            migrationBuilder.InsertData(
                table: "Fabricantes",
                columns: new[] { "Id", "Email", "Nacionalidad", "Nombre" },
                values: new object[,]
                {
                    { 1, "fujifilm@fujifilm.com", "Japón", "FujiFilm" },
                    { 2, "newtalent@newtalent.com", "EE.UU.", "NewTalent SA" },
                    { 3, "generalelectric@generalelectric.com", "España", "General Electric" },
                    { 4, "marandsa@gmail.com", " Argentina", "Marand SA" },
                    { 5, "dkotasa@dakotasa.com", "China", "D-kota SA" }
                });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "CodigoPostal", "Nombre", "ProvinciaId" },
                values: new object[,]
                {
                    { 1, "3040", "San Justo", null },
                    { 2, "3042", "Videla", null },
                    { 3, "3048", "Soledad", null }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "FabricanteId", "GarantiaFabricante", "Nombre", "Precio", "ProveedorId", "RubroId" },
                values: new object[,]
                {
                    { 1, null, "1 año", "Reloj SmartWatch W26", 15000.00m, null, null },
                    { 2, null, "100 años", "Foto 13x18", 300.00m, null, null },
                    { 3, null, "6 meses", "Funda Motorola G22", 3000.00m, null, null },
                    { 4, null, "1 año", "Combo mouse y teclado gamer", 11900.00m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "Id", "Email", "Nombre", "Teléfono" },
                values: new object[,]
                {
                    { 1, "dipromas@dipromas.com", "Dipromas SRL", "035148445566" },
                    { 2, "shoppcell@gmail.com", "ShoppCell", "01145553322" },
                    { 3, "hunistorsa@yahoo.com", "Hunistor SA", "01155443322" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Santa Fe" },
                    { 2, "Entre Ríos" },
                    { 3, "Córdoba" }
                });

            migrationBuilder.InsertData(
                table: "Rubros",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Fotografía" },
                    { 2, "Accesorios para celulares" },
                    { 3, "Relojería" },
                    { 4, "Informática" },
                    { 5, "Electrónica" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LocalidadId",
                table: "Clientes",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_ProvinciaId",
                table: "Localidades",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_FabricanteId",
                table: "Productos",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorId",
                table: "Productos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_RubroId",
                table: "Productos",
                column: "RubroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Fabricantes");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Rubros");

            migrationBuilder.DropTable(
                name: "Provincias");
        }
    }
}
