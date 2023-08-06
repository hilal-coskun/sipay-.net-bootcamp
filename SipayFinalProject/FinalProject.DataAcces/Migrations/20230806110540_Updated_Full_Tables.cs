using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class Updated_Full_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flat_Users_UserId",
                table: "Flat");

            migrationBuilder.DropColumn(
                name: "DuesesId",
                table: "Flat");

            migrationBuilder.DropColumn(
                name: "FlatNumber",
                table: "Flat");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Flat",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "InvoicesId",
                table: "Flat",
                newName: "FloorNo");

            migrationBuilder.RenameColumn(
                name: "FloorNumber",
                table: "Flat",
                newName: "FlatNo");

            migrationBuilder.RenameColumn(
                name: "BlokNo",
                table: "Flat",
                newName: "Block");

            migrationBuilder.RenameIndex(
                name: "IX_Flat_UserId",
                table: "Flat",
                newName: "IX_Flat_OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flat_Users_OwnerId",
                table: "Flat",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flat_Users_OwnerId",
                table: "Flat");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Flat",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "FloorNo",
                table: "Flat",
                newName: "InvoicesId");

            migrationBuilder.RenameColumn(
                name: "FlatNo",
                table: "Flat",
                newName: "FloorNumber");

            migrationBuilder.RenameColumn(
                name: "Block",
                table: "Flat",
                newName: "BlokNo");

            migrationBuilder.RenameIndex(
                name: "IX_Flat_OwnerId",
                table: "Flat",
                newName: "IX_Flat_UserId");

            migrationBuilder.AddColumn<int>(
                name: "DuesesId",
                table: "Flat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlatNumber",
                table: "Flat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Flat_Users_UserId",
                table: "Flat",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
