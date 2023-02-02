using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NewNamesToIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Months_MonthId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Users_UserId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_SpentInMonth_Months_MonthId",
                table: "SpentInMonth");

            migrationBuilder.DropForeignKey(
                name: "FK_SpentInMonth_Users_UserId",
                table: "SpentInMonth");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SpentInMonth",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "MonthId",
                table: "SpentInMonth",
                newName: "month_id");

            migrationBuilder.RenameIndex(
                name: "IX_SpentInMonth_UserId",
                table: "SpentInMonth",
                newName: "IX_SpentInMonth_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_SpentInMonth_MonthId",
                table: "SpentInMonth",
                newName: "IX_SpentInMonth_month_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Bill",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "MonthId",
                table: "Bill",
                newName: "month_id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_UserId",
                table: "Bill",
                newName: "IX_Bill_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_MonthId",
                table: "Bill",
                newName: "IX_Bill_month_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Months_month_id",
                table: "Bill",
                column: "month_id",
                principalTable: "Months",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Users_user_id",
                table: "Bill",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpentInMonth_Months_month_id",
                table: "SpentInMonth",
                column: "month_id",
                principalTable: "Months",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpentInMonth_Users_user_id",
                table: "SpentInMonth",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Months_month_id",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Users_user_id",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_SpentInMonth_Months_month_id",
                table: "SpentInMonth");

            migrationBuilder.DropForeignKey(
                name: "FK_SpentInMonth_Users_user_id",
                table: "SpentInMonth");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "SpentInMonth",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "month_id",
                table: "SpentInMonth",
                newName: "MonthId");

            migrationBuilder.RenameIndex(
                name: "IX_SpentInMonth_user_id",
                table: "SpentInMonth",
                newName: "IX_SpentInMonth_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SpentInMonth_month_id",
                table: "SpentInMonth",
                newName: "IX_SpentInMonth_MonthId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Bill",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "month_id",
                table: "Bill",
                newName: "MonthId");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_user_id",
                table: "Bill",
                newName: "IX_Bill_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_month_id",
                table: "Bill",
                newName: "IX_Bill_MonthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Months_MonthId",
                table: "Bill",
                column: "MonthId",
                principalTable: "Months",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Users_UserId",
                table: "Bill",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
