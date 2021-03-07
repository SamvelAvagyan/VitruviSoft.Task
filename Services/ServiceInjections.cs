using VitruviSoft.SamvelAvagyan.Services;
using VitruviSoft.SamvelAvagyan.Services.Impl;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceInjections
    {
        public static IServiceCollection AddService(this IServiceCollection services)
            => services
                .AddScoped(typeof(IBaseService<>), typeof(BaseService<>))
                .AddScoped<IGroupService, GroupService>()
                .AddScoped<IProviderService, ProviderService>();
    }
}
