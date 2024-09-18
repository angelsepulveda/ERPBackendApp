#region Categories
global using ERPBackend.WareHouses.Domain.Categories.Entities;
global using ERPBackend.SharedKernel.Domain.Interfaces.Repositories;
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