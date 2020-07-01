using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RBDNumeros.Domain.Entities;

namespace RBDNumeros.Infra.Repositories.MAP
{
    public class MapRede : IEntityTypeConfiguration<Rede>
    {
        public void Configure(EntityTypeBuilder<Rede> builder)
        {
            builder.ToTable("Rede");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(1000);
        }
    }
}
