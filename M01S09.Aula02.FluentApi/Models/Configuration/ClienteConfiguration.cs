using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace M01S09.Aula02.FluentApi.Models.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Cliente");

            builder.Property(e => e.EnderecoId)
                .HasMaxLength(150)
                .HasColumnName("Endereco_Id");

            builder.HasOne(x => x.EnderecoDeEntrega)
               .WithOne(p => p.Cliente)
               .HasForeignKey<Cliente>(d => d.EnderecoId)
               .HasConstraintName("FK_Cliente_Endereco");

            builder.ToTable("Cliente");
        }
    }
}
