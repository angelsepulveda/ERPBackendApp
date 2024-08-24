using Microsoft.Extensions.Logging;

namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCoreSettingsEFCoreSqlServer(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionSqlServerString = configuration.GetConnectionString("DbOptions") ?? throw new InvalidOperationException("No connection string 'DbOptions' found in appsettings.json") ;

        services.AddDbContext<SettingsApplicationDbContext>(options =>
            options.UseSqlServer(connectionSqlServerString));
        
        services.AddScoped<IUnitOfWork>(sp =>
            sp.GetRequiredService<SettingsApplicationDbContext>());

        return services;
    }
}