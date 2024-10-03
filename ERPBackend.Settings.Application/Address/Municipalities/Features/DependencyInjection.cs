namespace ERPBackend.Settings.Application.Address.Municipalities.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddMunicipalitiesFeatures(this IServiceCollection services)
    {
        services.AddScoped<IRegisterMunicipalityInputPort, RegisterMunicipalityInteractor>();
        services.AddScoped<IUpdateMunicipalityInputPort, UpdateMunicipalityInteractor>();
        services.AddScoped<IDeleteMunicipalityInputPort, DeleteMunicipalityInteractor>();
        services.AddScoped<IPaginationMunicipalityInputPort, PaginationMunicipalityInteractor>();
        services.AddScoped<IGetMunicipalityInputPort, GetMunicipalityInteractor>();
        services.AddScoped<IRestoreMunicipalityInputPort, RestoreMunicipalityInteractor>();
        
        return services;
    }
}