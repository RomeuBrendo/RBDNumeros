using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RBDNumeros.Domain.Entities;
using System;

namespace RBDNumeros.Infra.Repositories.MAP
{
    public class MapCliente : IEntityTypeConfiguration<Domain.Entities.Cliente>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(2000).IsRequired();

            builder.Property(x => x.Carteira).HasMaxLength(1);
        }
    }
}
