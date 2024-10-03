#region DocumentTypes
global using ERPBackend.Settings.Domain.DocumentTypes.ValueObjects;
global using ERPBackend.SharedKernel.Domain.Entities;
global using ERPBackend.Settings.Domain.DocumentTypes.Entities;
#endregion

#region VoucherTypes
global using ERPBackend.Settings.Domain.VoucherTypes.ValueObjects;
global using ERPBackend.Settings.Domain.VoucherTypes.Entities;
#endregion

#region Shared
global using ERPBackend.SharedKernel.Domain.Exceptions;
global using ERPBackend.SharedKernel.Domain.Paginations;
global using Microsoft.Extensions.DependencyInjection;
#endregion

#region Address

#region Countries
global using ERPBackend.Settings.Domain.Address.Countries.ValueObjects;
global using ERPBackend.Settings.Domain.Address.Countries.Entities;
global using ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;
global using ERPBackend.Settings.Domain.Address.Countries.Interfaces.Services;
global using ERPBackend.Settings.Domain.Address.Countries.Exceptions;
global using ERPBackend.Settings.Domain.Address.Countries.Services;
global using ERPBackend.Settings.Domain.Address.Countries;
global using ERPBackend.Settings.Domain.Address;
#endregion

#region Regions
global using ERPBackend.Settings.Domain.Address.Regions.ValueObjects;
global using ERPBackend.Settings.Domain.Address.Regions.Entities;
global using ERPBackend.Settings.Domain.Address.Regions.Interfaces.Services;
global using ERPBackend.Settings.Domain.Address.Regions.Exceptions;
global using ERPBackend.Settings.Domain.Address.Regions.Services;
global using ERPBackend.Settings.Domain.Address.Regions;
#endregion

#region Municipalities
global using ERPBackend.Settings.Domain.Address.Municipalities.ValueObjects;
global using ERPBackend.Settings.Domain.Address.Municipalities.Entities;
global using ERPBackend.Settings.Domain.Address.Municipalities.Exceptions;
global using ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;
global using ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Services;
global using ERPBackend.Settings.Domain.Address.Municipalities.Services;
global using ERPBackend.Settings.Domain.Address.Municipalities;
#endregion

#endregion