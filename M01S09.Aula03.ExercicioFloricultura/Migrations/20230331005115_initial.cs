using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M01S09.Aula03.ExercicioFloricultura.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente",
                        column: x => x.Cliente_Id,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo_Id = table.Column<int>(type: "int", nullable: false),
                    Estoque_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Produto_Estoque",
                        column: x => x.Estoque_Id,
                        principalTable: "Estoque",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Produto_Tipo",
                        column: x => x.Tipo_Id,
                        principalTable: "Tipo_Produto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PedidoProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produto_Id = table.Column<int>(type: "int", nullable: false),
                    Pedido_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Pedido_Produto",
                        column: x => x.Pedido_Id,
                        principalTable: "Pedido",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Produto_Pedido",
                        column: x => x.Produto_Id,
                        principalTable: "Produto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Cliente_Id",
                table: "Pedido",
                column: "Cliente_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_Pedido_Id",
                table: "PedidoProduto",
                column: "Pedido_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_Produto_Id",
                table: "PedidoProduto",
                column: "Produto_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Estoque_Id",
                table: "Produto",
                column: "Estoque_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Tipo_Id",
                table: "Produto",
                column: "Tipo_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoProduto");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Tipo_Produto");
        }
    }
}
