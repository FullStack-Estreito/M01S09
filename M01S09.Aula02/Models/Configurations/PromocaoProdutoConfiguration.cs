using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01S09.Aula02.Models.Configurations
{
    public class PromocaoProdutoConfiguration : IEntityTypeConfiguration<PromocaoProduto>
    {
        public void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            builder.HasOne(x => x.Promocao)
                .WithMany(p => p.Produtos)
                .HasForeignKey(x => x.PromocaoId)
                .HasConstraintName("FK__Promocao_Produto");

            builder.HasOne(x => x.Produto)
                .WithMany(p => p.Promocoes)
                .HasForeignKey(x => x.ProdutoId)
                .HasConstraintName("FK__Produto_Promocao");
        }
    }
}
