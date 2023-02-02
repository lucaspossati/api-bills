using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameFieldsInNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "assunto",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "cliente",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "email_destinatario",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "email_origem",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "mensagem",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "nome_usuario",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "num_destinatario",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Notifications",
                newName: "type");

            migrationBuilder.AddColumn<string>(
                name: "client_name",
                table: "Notifications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "message",
                table: "Notifications",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "origin_email",
                table: "Notifications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "recipient_email",
                table: "Notifications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "recipient_number",
                table: "Notifications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "Notifications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "user_name",
                table: "Notifications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "client_name",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "message",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "origin_email",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "recipient_email",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "recipient_number",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "user_name",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Notifications",
                newName: "tipo");

            migrationBuilder.AddColumn<string>(
                name: "assunto",
                table: "Notifications",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cliente",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email_destinatario",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email_origem",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mensagem",
                table: "Notifications",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nome_usuario",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "num_destinatario",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
