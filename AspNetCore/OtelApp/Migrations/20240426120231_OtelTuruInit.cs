using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtelApp.Migrations
{
    /// <inheritdoc />
    public partial class OtelTuruInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Odalar",
                columns: table => new
                {
                    OtelId = table.Column<int>(type: "int", nullable: false),
                    OdaId = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odalar", x => new { x.OdaId, x.OtelId });
                });

            migrationBuilder.CreateTable(
                name: "Otels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Turu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YildizSayisi = table.Column<byte>(type: "tinyint", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtelTurus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtelTurus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtelKapasiteler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kapasite = table.Column<int>(type: "int", nullable: false),
                    OtelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtelKapasiteler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtelKapasiteler_Otels_OtelId",
                        column: x => x.OtelId,
                        principalTable: "Otels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OtelKapasiteler_OtelId",
                table: "OtelKapasiteler",
                column: "OtelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Odalar");

            migrationBuilder.DropTable(
                name: "OtelKapasiteler");

            migrationBuilder.DropTable(
                name: "OtelTurus");

            migrationBuilder.DropTable(
                name: "Otels");
        }
    }
}
