using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01S09.Aula03.ExercicioFloricultura.Models.Configuration
{
    public class PedidoProdutoConfiguration : IEntityTypeConfiguration<PedidoProduto>
    {
        
        public void Configure(EntityTypeBuilder<PedidoProduto> builder)
        {
            builder.HasKey(x => x.Id);

            // 1 pra muitos
            builder.HasOne(x => x.Produto) //1
                    .WithMany(p => p.Pedidos) //muitos
                    .HasForeignKey(x => x.Produto_Id) // FK representante
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Produto_Pedido");

            //1 para muitos
            builder.HasOne(x => x.Pedido)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(x => x.Pedido_Id) // FK representante
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pedido_Produto");

            builder.ToTable("PedidoProduto");
        }
    }
}
