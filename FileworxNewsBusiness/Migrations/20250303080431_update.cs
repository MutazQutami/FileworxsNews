using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileworxNewsBusiness.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entity_User_CreatorId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_User_LastModifierId",
                table: "Entity");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_User_CreatorId",
                table: "Entity",
                column: "CreatorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_User_LastModifierId",
                table: "Entity",
                column: "LastModifierId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entity_User_CreatorId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_User_LastModifierId",
                table: "Entity");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_User_CreatorId",
                table: "Entity",
                column: "CreatorId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_User_LastModifierId",
                table: "Entity",
                column: "LastModifierId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
