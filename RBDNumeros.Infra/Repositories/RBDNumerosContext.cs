using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Infra.Repositories.MAP;

namespace RBDNumeros.Infra.Repositories
{
    public class RBDNumerosContext : DbContext       
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Domain.Entities.Cliente> Clientes { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ConfiguracaoPlanilha> ConfiguracaoPlanilhas { get; set; }
        public DbSet<Sla> Sla { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=RBDNumeros;Uid=root;Pwd=root;");
            }
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<TableNameFromDbSetConvention>();

            //ignorar classes
            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new MapCategoria());
            modelBuilder.ApplyConfiguration(new MapCliente());
            modelBuilder.ApplyConfiguration(new MapTecnico());
            modelBuilder.ApplyConfiguration(new MapTicket());
            modelBuilder.ApplyConfiguration(new MapConfiguracaoPlanilha());
            modelBuilder.ApplyConfiguration(new MapSla());

            base.OnModelCreating(modelBuilder);
        }
    }
}
