using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RBDNumeros.Domain.Entities;

namespace RBDNumeros.Infra.Repositories.MAP
{
    public class MapTecnico : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.ToTable("Tecnico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Carteira);

            builder.Property(x => x.ContabilizarNumeros).HasColumnName("ContabilizarNumeros").IsRequired();

        }
    }
}
