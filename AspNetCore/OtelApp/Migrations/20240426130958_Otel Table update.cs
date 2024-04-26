using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtelApp.Migrations
{
    /// <inheritdoc />
    public partial class OtelTableupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Otels");

            migrationBuilder.DropColumn(
                name: "Turu",
                table: "Otels");

            migrationBuilder.DropColumn(
                name: "Ulke",
                table: "Otels");

            migrationBuilder.AddColumn<int>(
                name: "OtelTuruId",
                table: "Otels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SehirId",
                table: "Otels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UlkeId",
                table: "Otels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Otels_OtelTuruId",
                table: "Otels",
                column: "OtelTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_Otels_SehirId",
                table: "Otels",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Otels_UlkeId",
                table: "Otels",
                column: "UlkeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Otels_OtelTurus_OtelTuruId",
                table: "Otels",
                column: "OtelTuruId",
                principalTable: "OtelTurus",
                principalColumn: "Id"
                );

            migrationBuilder.AddForeignKey(
                name: "FK_Otels_Sehirler_SehirId",
                table: "Otels",
                column: "SehirId",
                principalTable: "Sehirler",
                principalColumn: "Id"
                );

            migrationBuilder.AddForeignKey(
                name: "FK_Otels_Ulkeler_UlkeId",
                table: "Otels",
                column: "UlkeId",
                principalTable: "Ulkeler",
                principalColumn: "Id"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Otels_OtelTurus_OtelTuruId",
                table: "Otels");

            migrationBuilder.DropForeignKey(
                name: "FK_Otels_Sehirler_SehirId",
                table: "Otels");

            migrationBuilder.DropForeignKey(
                name: "FK_Otels_Ulkeler_UlkeId",
                table: "Otels");

            migrationBuilder.DropIndex(
                name: "IX_Otels_OtelTuruId",
                table: "Otels");

            migrationBuilder.DropIndex(
                name: "IX_Otels_SehirId",
                table: "Otels");

            migrationBuilder.DropIndex(
                name: "IX_Otels_UlkeId",
                table: "Otels");

            migrationBuilder.DropColumn(
                name: "OtelTuruId",
                table: "Otels");

            migrationBuilder.DropColumn(
                name: "SehirId",
                table: "Otels");

            migrationBuilder.DropColumn(
                name: "UlkeId",
                table: "Otels");

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Otels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Turu",
                table: "Otels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ulke",
                table: "Otels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
