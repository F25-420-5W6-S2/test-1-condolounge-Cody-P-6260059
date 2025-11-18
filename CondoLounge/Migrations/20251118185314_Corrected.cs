using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondoLounge.Migrations
{
    /// <inheritdoc />
    public partial class Corrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condo_Building_CondoNumber",
                table: "Condo");

            migrationBuilder.DropIndex(
                name: "IX_Condo_CondoNumber",
                table: "Condo");

            migrationBuilder.AddColumn<int>(
                name: "CondoIdNumber",
                table: "Condo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Condo_CondoIdNumber",
                table: "Condo",
                column: "CondoIdNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Condo_Building_CondoIdNumber",
                table: "Condo",
                column: "CondoIdNumber",
                principalTable: "Building",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condo_Building_CondoIdNumber",
                table: "Condo");

            migrationBuilder.DropIndex(
                name: "IX_Condo_CondoIdNumber",
                table: "Condo");

            migrationBuilder.DropColumn(
                name: "CondoIdNumber",
                table: "Condo");

            migrationBuilder.CreateIndex(
                name: "IX_Condo_CondoNumber",
                table: "Condo",
                column: "CondoNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Condo_Building_CondoNumber",
                table: "Condo",
                column: "CondoNumber",
                principalTable: "Building",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
