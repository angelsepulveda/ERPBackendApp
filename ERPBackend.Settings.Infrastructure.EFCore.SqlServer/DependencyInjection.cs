namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer;

public static class DependencyInjection
{
    public static IServiceCollection AddSettingsEFCoreSqlServer(this IServiceCollection services,
       IConfiguration configuration)
    {
        services.AddCoreSettingsEFCoreSqlServer(configuration);
        services.AddDocumentTypesEFCoreSqlServer();
        services.AddVoucherTypesEFCoreSqlServer();

        return services;
    }
}