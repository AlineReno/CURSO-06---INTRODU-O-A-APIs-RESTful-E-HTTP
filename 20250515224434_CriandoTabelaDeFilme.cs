using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace FilmesAPI.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaDeFilme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySqlServer:ValueGenerationSrategy",MySQLValueGenerationStrategy.IdentityColumn),
                    Título = table.Column<string>(type:"text", nullable:false),
                    Diretor = table.Column<string>(type: "text", nullable: false),
                    Genero = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Duracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
