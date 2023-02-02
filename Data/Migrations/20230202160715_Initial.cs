using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mensagem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    emaildestinatario = table.Column<string>(name: "email_destinatario", type: "nvarchar(max)", nullable: false),
                    numdestinatario = table.Column<string>(name: "num_destinatario", type: "nvarchar(max)", nullable: false),
                    emailorigem = table.Column<string>(name: "email_origem", type: "nvarchar(max)", nullable: false),
                    assunto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nomeusuario = table.Column<string>(name: "nome_usuario", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SpentInMonth",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    spent = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    spentpercentageabove = table.Column<decimal>(name: "spent_percentage_above", type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpentInMonth", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    salarysave = table.Column<decimal>(name: "salary_save", type: "decimal(18,4)", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "SpentInMonth");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
