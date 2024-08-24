namespace ERPBackend.Settings.Application.DocumentTypes.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddDocumentTypesFeatures(this IServiceCollection services)
    {
        services.AddScoped<IRegisterDocumentTypeInputPort, RegisterDocumentTypeInteractor>();
        services.AddScoped<IGetAllDocumentTypeInputPort, GetAllDocumentTypeInteractor>();
        services.AddScoped<IDeleteDocumentTypeInputPort, DeleteDocumentTypeInteractor>();
        services.AddScoped<IDeleteDocumentTypeInputPort, DeleteDocumentTypeInteractor>();
        services.AddScoped<IRestoreDocumentTypeInputPort, RestoreDocumentTypeInteractor>();

        return services;
    }
}