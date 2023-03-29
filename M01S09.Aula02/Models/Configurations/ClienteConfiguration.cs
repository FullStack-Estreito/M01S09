using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01S09.Aula02.Models.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //1 para 1
            builder.HasOne(x => x.EnderecoDeEntrega)
                .WithOne(p => p.Cliente)
                .HasForeignKey<Cliente>(x => x.EnderecoId)
                .HasConstraintName("FK_Cliente_Endereco");
        }
    }
}
