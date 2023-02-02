using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NewNameBills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Months_month_id",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Users_user_id",
                table: "Bill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.RenameTable(
                name: "Bill",
                newName: "Bills");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_user_id",
                table: "Bills",
                newName: "IX_Bills_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_month_id",
                table: "Bills",
                newName: "IX_Bills_month_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bills",
                table: "Bills",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Months_month_id",
                table: "Bills",
                column: "month_id",
                principalTable: "Months",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Users_user_id",
                table: "Bills",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Months_month_id",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Users_user_id",
                table: "Bills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bills",
                table: "Bills");

            migrationBuilder.RenameTable(
                name: "Bills",
                newName: "Bill");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_user_id",
                table: "Bill",
                newName: "IX_Bill_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_month_id",
                table: "Bill",
                newName: "IX_Bill_month_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                column: "id");

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
        }
    }
}
