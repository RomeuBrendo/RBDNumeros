using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RBDNumeros.Domain.Entities;

namespace RBDNumeros.Infra.Repositories.MAP
{
    public class MapConfiguracaoPlanilha : IEntityTypeConfiguration<ConfiguracaoPlanilha>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoPlanilha> builder)
        {
            builder.ToTable("ConfiguracaoPlanilha");

            builder.HasKey(x => x.Id);
        }
    }
}
