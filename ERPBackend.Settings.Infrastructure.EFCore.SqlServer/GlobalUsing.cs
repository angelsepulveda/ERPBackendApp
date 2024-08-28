#region Libreries
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
#endregion

#region DocumentTypes
global using ERPBackend.Settings.Domain.DocumentTypes.Entities;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Configurations;
global using ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes;
global using ERPBackend.Settings.Domain.DocumentTypes.ValueObjects;
#endregion

#region Kernel
global using ERPBackend.SharedKernel.Domain.Paginations;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Core.Contexts;
global using ERPBackend.SharedKernel.Domain.Interfaces.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Core;
#endregion