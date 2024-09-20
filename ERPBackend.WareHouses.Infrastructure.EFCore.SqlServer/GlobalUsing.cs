#region Categories
global using ERPBackend.WareHouses.Domain.Categories.Entities;
global using ERPBackend.WareHouses.Domain.Categories.ValueObjects;
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Configurations;
global using ERPBackend.WareHouses.Domain.Categories.Interfaces.Repositories;
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Repositories;
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories;
#endregion

#region Libreries
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Configuration;
#endregion

#region Core
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Core.Contexts;
global using ERPBackend.WareHouses.Domain.Core.Interfaces;
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Core;
#endregion

#region Shared
global using ERPBackend.SharedKernel.Domain.Paginations;
#endregion

#region Brands
global using ERPBackend.WareHouses.Domain.Brands.Entities;
global using ERPBackend.WareHouses.Domain.Brands.ValueObjects;
global using ERPBackend.WareHouses.Domain.Brands.Interfaces.Repositories;
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Repositories;
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands;
#endregion

#region MeasurementUnits
global using ERPBackend.WareHouses.Domain.MeasurementUnits.Entities;
global using ERPBackend.WareHouses.Domain.MeasurementUnits.ValueObjects;
global using ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Repositories;
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;
global using ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits;
#endregion