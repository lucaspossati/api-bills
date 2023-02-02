using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class RelationInSpent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MonthId",
                table: "SpentInMonth",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SpentInMonth",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SpentInMonth_MonthId",
                table: "SpentInMonth",
                column: "MonthId");

            migrationBuilder.CreateIndex(
                name: "IX_SpentInMonth_UserId",
                table: "SpentInMonth",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpentInMonth_Months_MonthId",
                table: "SpentInMonth",
                column: "MonthId",
                principalTable: "Months",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpentInMonth_Users_UserId",
                table: "SpentInMonth",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpentInMonth_Months_MonthId",
                table: "SpentInMonth");

            migrationBuilder.DropForeignKey(
                name: "FK_SpentInMonth_Users_UserId",
                table: "SpentInMonth");

            migrationBuilder.DropIndex(
                name: "IX_SpentInMonth_MonthId",
                table: "SpentInMonth");

            migrationBuilder.DropIndex(
                name: "IX_SpentInMonth_UserId",
                table: "SpentInMonth");

            migrationBuilder.DropColumn(
                name: "MonthId",
                table: "SpentInMonth");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SpentInMonth");
        }
    }
}
