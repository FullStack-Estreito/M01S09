using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01S09.Aula03.ExercicioFloricultura.Models.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                    .HasMaxLength(150);

            builder.ToTable("Cliente");
        }
    }
}
