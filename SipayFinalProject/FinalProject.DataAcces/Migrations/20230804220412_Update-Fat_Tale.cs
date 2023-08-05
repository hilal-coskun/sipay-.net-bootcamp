using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFat_Tale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DuesesId",
                table: "Flat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InvoicesId",
                table: "Flat",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DuesesId",
                table: "Flat");

            migrationBuilder.DropColumn(
                name: "InvoicesId",
                table: "Flat");
        }
    }
}
