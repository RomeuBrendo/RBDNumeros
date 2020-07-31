using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RBDNumeros.Domain.Entities;

namespace RBDNumeros.Infra.Repositories.MAP
{
    public class MapSla : IEntityTypeConfiguration<Sla>
    {
        public void Configure(EntityTypeBuilder<Sla> builder)
        {
            builder.ToTable("Sla");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Dentro).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Acima20).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Estourado).HasMaxLength(10).IsRequired();
        }
    }
}
