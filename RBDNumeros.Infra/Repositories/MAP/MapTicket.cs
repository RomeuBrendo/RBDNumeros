using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RBDNumeros.Domain.Entities;

namespace RBDNumeros.Infra.Repositories.MAP
{
    public class MapTicket : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NumeroTicket).IsRequired();
            builder.Property(x => x.DataAberturaTicket).IsRequired().HasColumnName("DataAbertura");
            builder.Property(x => x.DataAberturaTicket).HasColumnName("DataFinalizacao");

            builder.HasOne(x => x.Cliente).WithMany().HasForeignKey("ClienteId");
            builder.HasOne(x => x.Tecnico).WithMany().HasForeignKey("TecnicoId");
            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey("CategoriaId");

        }
    }
}
