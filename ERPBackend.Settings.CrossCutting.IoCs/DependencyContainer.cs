namespace ERPBackend.Settings.CrossCutting.IoCs;

public static class DependencyContainer
{
    public static IServiceCollection AddSettingsServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddSettingsApplication()
            .AddSettingsDomain()
            .AddSettingsPresenters()
            .AddSettingsEFCoreSqlServer(configuration);

        return services;
    }
}