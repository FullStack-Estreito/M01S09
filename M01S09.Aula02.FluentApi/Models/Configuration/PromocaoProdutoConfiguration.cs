using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01S09.Aula02.FluentApi.Models.Configurations
{
    public class PromocaoProdutoConfiguration : IEntityTypeConfiguration<PromocaoProduto>
    {
        public void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Produto)
                .WithMany(p => p.Promocoes)
                .HasForeignKey(x => x.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Produto_Promocao");

            builder.HasOne(x => x.Promocao)
                .WithMany(p => p.Produtos)
                .HasForeignKey(x => x.PromocaoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Promocao_Produto");
            
            builder.ToTable("PromocaoProduto");
        }
    }
}
