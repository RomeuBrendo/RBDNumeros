using Microsoft.Extensions.DependencyInjection;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Domain.Services;
using RBDNumeros.Infra.Repositories;
using RBDNumeros.Infra.Repositories.Transactions;
using System;
using System.Windows.Forms;


namespace RBDNumeros.Viwer
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();
            Application.Run(new FrmPrincipal());
            
        }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<RBDNumerosContext, RBDNumerosContext>();

            

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IRepositoryConfiguracaoPlanilha, RepositoryConfiguracaoPlanilha>();
            services.AddTransient<IRepositoryCategoria, RepositoryCategoria>();
            services.AddTransient<IRepositoryCliente, RepositoryCliente>();
            services.AddTransient<IRepositoryTecnico, RepositoryTecnico>();
            services.AddTransient<IRepositoryTicket, RepositoryTicket>();
            services.AddTransient<IRepositorySla, RepositorySla>();
            //Services
            services.AddTransient<IServiceConfiguracaoPlanilha, ServiceConfiguracaoPlanilha>();
            services.AddTransient<IServiceCategoria, ServiceCategoria>();
            services.AddTransient<IServiceCliente, ServiceCliente>();
            services.AddTransient<IServiceTecnico, ServiceTecnico>();
            services.AddTransient<IServiceTicket, ServiceTicket>();
            services.AddTransient<IServiceSla, ServiceSla>();
            services.AddTransient<IServiceKPI, ServiceKPI>();

            

            ServiceProvider = services.BuildServiceProvider();

        }
    }
}
