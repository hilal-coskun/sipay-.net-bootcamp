using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlatUser");

            migrationBuilder.DropIndex(
                name: "IX_Flat_UserId",
                table: "Flat");

            migrationBuilder.CreateIndex(
                name: "IX_Flat_UserId",
                table: "Flat",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Flat_Users_UserId",
                table: "Flat",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flat_Users_UserId",
                table: "Flat");

            migrationBuilder.DropIndex(
                name: "IX_Flat_UserId",
                table: "Flat");

            migrationBuilder.CreateTable(
                name: "FlatUser",
                columns: table => new
                {
                    FlatsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatUser", x => new { x.FlatsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_FlatUser_Flat_FlatsId",
                        column: x => x.FlatsId,
                        principalTable: "Flat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlatUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flat_UserId",
                table: "Flat",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FlatUser_UsersId",
                table: "FlatUser",
                column: "UsersId");
        }
    }
}
