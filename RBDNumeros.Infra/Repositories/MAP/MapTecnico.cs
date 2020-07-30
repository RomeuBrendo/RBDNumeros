using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RBDNumeros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBDNumeros.Infra.Repositories.MAP
{
    public class MapTecnico : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.ToTable("Tecnico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ContabilizarNumeros).HasColumnName("ContabilizarNumeros").IsRequired();

        }
    }
}
