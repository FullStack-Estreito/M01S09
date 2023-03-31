using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01S09.Aula03.ExercicioFloricultura.Models.Configuration
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(e => e.Id);

            //1 para muitos
            builder.HasOne(x => x.Cliente) //1
                .WithMany(p => p.Pedidos) //muitos
                .HasForeignKey(d => d.Cliente_Id) // FK representante
                .HasConstraintName("FK_Pedido_Cliente");

            builder.ToTable("Pedido");
        }
    }
}
