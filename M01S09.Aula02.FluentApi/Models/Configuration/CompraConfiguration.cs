using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01S09.Aula02.FluentApi.Models.Configurations
{
    public class CompraConfiguration : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.ClienteId)
                .HasColumnName("Cliente_Id");

            builder.Property(p => p.ProdutoId)
                .HasColumnName("Produto_Id");

            builder.HasOne(x => x.Produtos)
                .WithMany(p => p.Compras)
                .HasForeignKey(d => d.ProdutoId)
                .HasConstraintName("FK_Compra_Produto");

            builder.HasOne(x => x.Cliente)
                .WithMany(p => p.Compras)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_Compra_Cliente");

            builder.ToTable("Compra");

        }
    }
}
