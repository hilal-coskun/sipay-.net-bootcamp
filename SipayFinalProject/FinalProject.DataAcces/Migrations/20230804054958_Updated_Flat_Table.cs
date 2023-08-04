using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class Updated_Flat_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlatId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlatId",
                table: "Users");
        }
    }
}
