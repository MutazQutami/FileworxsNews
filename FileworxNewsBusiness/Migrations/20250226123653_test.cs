using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileworxNewsBusiness.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    GuidValue = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.GuidValue);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    GuidValue = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.GuidValue);
                    table.ForeignKey(
                        name: "FK_Contents_Entities_GuidValue",
                        column: x => x.GuidValue,
                        principalTable: "Entities",
                        principalColumn: "GuidValue",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    GuidValue = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogInName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.GuidValue);
                    table.ForeignKey(
                        name: "FK_Users_Entities_GuidValue",
                        column: x => x.GuidValue,
                        principalTable: "Entities",
                        principalColumn: "GuidValue",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    GuidValue = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.GuidValue);
                    table.ForeignKey(
                        name: "FK_News_Contents_GuidValue",
                        column: x => x.GuidValue,
                        principalTable: "Contents",
                        principalColumn: "GuidValue",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    GuidValue = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.GuidValue);
                    table.ForeignKey(
                        name: "FK_Photos_Contents_GuidValue",
                        column: x => x.GuidValue,
                        principalTable: "Contents",
                        principalColumn: "GuidValue",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CreatorId",
                table: "Contents",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_LastModifierId",
                table: "Contents",
                column: "LastModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LastModifier",
                table: "Users",
                column: "LastModifier");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LogInName",
                table: "Users",
                column: "LogInName",
                unique: true,
                filter: "[LogInName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Entities");
        }
    }
}
