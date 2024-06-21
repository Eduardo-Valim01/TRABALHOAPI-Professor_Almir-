using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRABALHOAPI.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    marca = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    preço = table.Column<float>(type: "real", nullable: false),
                    datafabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datavalidade = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
