namespace ERPBackend.Settings.Infrastructure.Presenters.Address;

public static class DependencyInjection
{
    public static IServiceCollection AddAddressPresenters(this IServiceCollection services)
    {
        services.AddCountriesPresenters();
        services.AddRegionsPresenter();
        
        return services;
    }
}