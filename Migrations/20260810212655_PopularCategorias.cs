using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MacBurgers.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
    INSERT INTO "Categoria"("CategoriaName", "Descricao") 
    VALUES('Normal', 'Lanche feito com ingredientes normais');
""");

            migrationBuilder.Sql("""
    INSERT INTO "Categoria"("CategoriaName", "Descricao") 
    VALUES('Natural', 'Lanche feito com ingredientes integrais e naturais');
""");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Apaga os dados e limpa os contadores de ID (IDENTITY) no PostgreSQL
            migrationBuilder.Sql("""TRUNCATE TABLE "Categoria" RESTART IDENTITY CASCADE;""");
        }
    }
}
