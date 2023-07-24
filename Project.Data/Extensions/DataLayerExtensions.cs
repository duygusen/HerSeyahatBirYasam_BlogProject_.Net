using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Data.Context;
using Project.Data.Repositories.Abstractions;
using Project.Data.Repositories.Concretes;
using Project.Data.UnitOfWorks;

namespace Project.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(config.GetConnectionString("DefaultConnection")));
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
