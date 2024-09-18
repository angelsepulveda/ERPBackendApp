namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCoreWareHousesEFCoreSqlServer(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionSqlServerString = configuration.GetConnectionString("DbOptionsWareHouses") ?? throw new InvalidOperationException("No connection string 'DbOptions' found in appsettings.json") ;

        services.AddDbContext<WareHousesApplicationDbContext>(options =>
            options.UseSqlServer(connectionSqlServerString));
        
        services.AddScoped<IWareHouseUnitOfWork>(sp =>
            sp.GetRequiredService<WareHousesApplicationDbContext>());

        return services;
    }
}