using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Domain.Services;
using RBDNumeros.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBDNumeros.Viwer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IServiceCollection services = new ServiceCollection();
            ConfigureRepositories(services);
            Application.Run(new FrmPrincipal());
            
        }

        public static void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<RBDNumerosContext, RBDNumerosContext>();

      //      services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IRepositoryCategoria, RepositoryCategoria>();
            services.AddTransient<IRepositoryCliente, RepositoryCliente>();
            services.AddTransient<IRepositoryRede, RepositoryRede>();
            services.AddTransient<IRepositoryTecnico, RepositoryTecnico>();
            services.AddTransient<IRepositoryTicket,  RepositoryTicket>();

            //Services
            services.AddTransient<IServiceCategoria, ServiceCategoria>();
            services.AddTransient<IServiceCliente, ServiceCliente>();
            services.AddTransient<IServiceRede, ServiceRede>();
            services.AddTransient<IServiceTecnico, ServiceTecnico>();
            services.AddTransient<IServiceTicket, ServiceTicket>();

        }
    }
}
