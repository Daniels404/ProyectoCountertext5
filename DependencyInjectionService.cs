using ProyectoCountertext4.Repositories;
using ProyectoCountertext4.Repositories.interfaz;
using Microsoft.EntityFrameworkCore;
using ProyectoCountertext4.Data;
using ProyectoCountertext4.Data.interfaz;
using ProyectoCountertext4.Data.repositories;
using ProyectoCountertext4.Data.repositoriess;

namespace ProyectoCountertext4;
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration _configuration)
        {
            string connectionString = "";
            connectionString = _configuration["ConnectionStrings:SQLConnectionStrings"];

            services.AddDbContext<CounterTexDBContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IAdministrador, RepositorioAdministrador>();
            services.AddScoped<IEmpleado, RepositorioEmpleado>();
            services.AddScoped<IProvedor, RepositorioProveedor>();
            services.AddScoped<IRegistro, RepositorioRegistro>();
            services.AddScoped<ISatelite, RepositorioSatelite>();
            services.AddScoped<ITokens, TokensRepository>();
            services.AddScoped<IUsuarios, RepositorioUsuarios>();
        return services;
        }
    }

