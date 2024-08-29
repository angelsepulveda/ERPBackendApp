namespace ERPBackend.Settings.Application.VoucherTypes;

public static class DependencyInjection
{
    public static IServiceCollection AddVoucherTypesApplication(this IServiceCollection services)
    {
        services.AddVoucherTypesFeatures();
        
        return services;
    }
}