namespace ERPBackend.SharedKernel.CrossCutting.IoCs;

public static class DependencyInjection
{
    public static IServiceCollection AddERPServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddFluentValidationServices();
        
        services.AddSettingsServices(configuration);
        
        return services;
    }
}