using Microsoft.EntityFrameworkCore;
using VitruviSoft.SamvelAvagyan.Repository;
using VitruviSoft.SamvelAvagyan.Repository.Impl;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DatabaseContext>(con => con.UseSqlServer(connectionString));
            return services;
        }

        public static IServiceCollection AddRepositoryContracts(this IServiceCollection services)
            => services
                .AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>))
                .AddScoped<IGroupRepository, GroupRepository>()
                .AddScoped<IProviderRepository, ProviderRepository>();

        public static IServiceCollection AddRepository(this IServiceCollection services, string connectionString)
            => services
                .AddDbContext(connectionString)
                .AddRepositoryContracts();
    }
}
