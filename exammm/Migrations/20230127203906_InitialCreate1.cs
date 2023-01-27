using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exammm.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Male = table.Column<int>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saleds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "DATE", nullable: false),
                    Sum = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saleds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saleds_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Good_Selads",
                columns: table => new
                {
                    GoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    SaledId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Good_Selads", x => new { x.GoodId, x.SaledId });
                    table.ForeignKey(
                        name: "FK_Good_Selads_Goods_GoodId",
                        column: x => x.GoodId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Good_Selads_Saleds_SaledId",
                        column: x => x.SaledId,
                        principalTable: "Saleds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Good_Selads_SaledId",
                table: "Good_Selads",
                column: "SaledId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_Name",
                table: "Goods",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_Price",
                table: "Goods",
                column: "Price");

            migrationBuilder.CreateIndex(
                name: "IX_Saleds_Date",
                table: "Saleds",
                column: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_Saleds_Sum",
                table: "Saleds",
                column: "Sum");

            migrationBuilder.CreateIndex(
                name: "IX_Saleds_UserId",
                table: "Saleds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Age",
                table: "Users",
                column: "Age");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Male",
                table: "Users",
                column: "Male");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Name",
                table: "Users",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Good_Selads");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Saleds");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
