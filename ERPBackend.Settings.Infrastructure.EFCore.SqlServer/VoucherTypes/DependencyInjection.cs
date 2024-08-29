

namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes;

public static class DependencyInjection
{
    public static IServiceCollection AddVoucherTypesEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddVoucherTypeRepositories();
        
        return services;
    }
}