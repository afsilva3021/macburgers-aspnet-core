using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MacBurgers.Migrations
{
    public partial class PopularLancheNatural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                INSERT INTO Lanches
                (
                    CategoriaId,
                    DescricaoCurta,
                    DescricaoDetalhada,
                    EmEstoque,
                    ImagemUrl,
                    ImagemThubnailUrl,
                    IsLanchePreferido,
                    Nome,
                    Preco,
                    DataDeCricao,
                    Atualizacao
                )
                VALUES
                (
                    1,
                    N'Pão, hambúrguer, ovo, presunto, queijo e batata palha',
                    N'Delicioso pão de hambúrguer com ovo frito, presunto e queijo de primeira qualidade acompanhado com batata palha.',
                    1,
                    N'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',
                    N'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',
                    0,
                    N'Cheese Salada',
                    12.50,
                    GETDATE(),
                    GETDATE()
                );
                """
            );

            migrationBuilder.Sql(
                """
                INSERT INTO Lanches
                (
                    CategoriaId,
                    DescricaoCurta,
                    DescricaoDetalhada,
                    EmEstoque,
                    ImagemUrl,
                    ImagemThubnailUrl,
                    IsLanchePreferido,
                    Nome,
                    Preco,
                    DataDeCricao,
                    Atualizacao
                )
                VALUES
                (
                    1,
                    N'Pão, presunto, mussarela e tomate',
                    N'Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate, preparado com carinho.',
                    1,
                    N'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',
                    N'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',
                    0,
                    N'Misto Quente',
                    8.00,
                    GETDATE(),
                    GETDATE()
                );
                """
            );

            migrationBuilder.Sql(
                """
                INSERT INTO Lanches
                (
                    CategoriaId,
                    DescricaoCurta,
                    DescricaoDetalhada,
                    EmEstoque,
                    ImagemUrl,
                    ImagemThubnailUrl,
                    IsLanchePreferido,
                    Nome,
                    Preco,
                    DataDeCricao,
                    Atualizacao
                )
                VALUES
                (
                    1,
                    N'Pão, hambúrguer, presunto, mussarela e batata palha',
                    N'Pão de hambúrguer especial com hambúrguer de nossa preparação, presunto e mussarela, acompanhado de batata palha.',
                    1,
                    N'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',
                    N'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',
                    0,
                    N'Cheese Burger',
                    11.00,
                    GETDATE(),
                    GETDATE()
                );
                """
            );

            migrationBuilder.Sql(
                """
                INSERT INTO Lanches
                (
                    CategoriaId,
                    DescricaoCurta,
                    DescricaoDetalhada,
                    EmEstoque,
                    ImagemUrl,
                    ImagemThubnailUrl,
                    IsLanchePreferido,
                    Nome,
                    Preco,
                    DataDeCricao,
                    Atualizacao
                )
                VALUES
                (
                    2,
                    N'Pão integral, queijo branco, peito de peru, cenoura, alface e iogurte',
                    N'Pão integral natural com queijo branco, peito de peru, cenoura ralada, alface picada e iogurte natural.',
                    1,
                    N'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',
                    N'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',
                    1,
                    N'Lanche Natural Peito de Peru',
                    15.00,
                    GETDATE(),
                    GETDATE()
                );
                """
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                DELETE FROM Lanches
                WHERE Nome IN
                (
                    N'Cheese Salada',
                    N'Misto Quente',
                    N'Cheese Burger',
                    N'Lanche Natural Peito de Peru'
                );
                """
            );
        }
    }
}