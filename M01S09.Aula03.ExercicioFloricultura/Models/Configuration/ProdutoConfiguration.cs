using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01S09.Aula03.ExercicioFloricultura.Models.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Preco).
                HasColumnType("decimal(5,2)");

            // 1 para muitos
            builder.HasOne(x => x.Tipo) // 1
                .WithMany(p => p.Produtos)// muitos
                .HasForeignKey(x => x.Tipo_Id)// FK representante
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Produto_Tipo");

            // 1 para 1
            builder.HasOne(x => x.Estoque) // 1 
                    .WithOne(p => p.Produto) // 1
                    .HasForeignKey<Produto>(x => x.Estoque_Id) // FK representante
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Produto_Estoque");
            
            builder.ToTable("Produto");
        }
    }
}
