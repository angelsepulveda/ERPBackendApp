using ERPBackend.SharedKernel.Validations.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ERPBackend.SharedKernel.Validations.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddDefaultModelValidatorHub(this IServiceCollection services)
    {
        services.TryAddScoped(typeof(IModelValidatorHub<>), typeof(ModelValidatorHub<>));

        return services;
    }

    public static IServiceCollection AddModelValidator<ModelType, ModelValidatorType>(this IServiceCollection services)
        where ModelValidatorType : class, IModelValidator<ModelType>
    {
        services.AddDefaultModelValidatorHub();

        services.AddScoped<IModelValidator<ModelType>, ModelValidatorType>();

        return services;
    }
}