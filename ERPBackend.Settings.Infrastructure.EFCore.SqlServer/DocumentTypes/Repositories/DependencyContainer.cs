﻿namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Repositories;

public static class DependencyContainer
{
    public static IServiceCollection AddDocumentTypeRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRegisterDocumentTypeRepository, RegisterDocumentTypeRepository>();
        services.AddScoped<IUpdateDocumentTypeRepository, UpdateDocumentTypeRepository>();
        services.AddScoped<IGetDocumentTypeRepository, GetDocumentTypeRepository>();
        services.AddScoped<IGetAllDocumentTypeRepository, GetAllDocumentTypeRepository>();
        services.AddScoped<IGetByIdDocumentTypeRepository, GetByIdDocumentTypeRepository>();

        return services;
    }
}