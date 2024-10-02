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

#region VoucherTypes
global using ERPBackend.Settings.Domain.VoucherTypes.Entities;
global using ERPBackend.Settings.Domain.VoucherTypes.ValueObjects;
global using ERPBackend.Settings.Domain.VoucherTypes.Interfaces.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes;
#endregion

#region Kernel
global using ERPBackend.SharedKernel.Domain.Paginations;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Core.Contexts;
global using ERPBackend.SharedKernel.Domain.Interfaces.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Core;
#endregion

#region Address

#region Countries
global using ERPBackend.Settings.Domain.Address.Countries.Entities;
global using ERPBackend.Settings.Domain.Address.Countries.ValueObjects;
global using ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address;
#endregion

#region Regions
global using ERPBackend.Settings.Domain.Address.Regions.Entities;
global using ERPBackend.Settings.Domain.Address.Regions.ValueObjects;
global using ERPBackend.Settings.Domain.Address.Regions.Interfaces.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;
global using ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions;
#endregion

#endregion