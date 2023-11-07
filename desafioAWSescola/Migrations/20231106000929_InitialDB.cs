using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafioAWSescola.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false),
                    Idade = table.Column<byte>(type: "tinyint", maxLength: 2, nullable: false),
                    NotaPrimeiroSemestre = table.Column<float>(type: "real", nullable: true),
                    NotaSegundoSemestre = table.Column<float>(type: "real", nullable: true),
                    Docente = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    Sala = table.Column<int>(type: "int", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
