#region Categories
global using ERPBackend.WareHouses.Application.Categories.Features.Register.Dtos;
global using ERPBackend.WareHouses.Domain.Categories.Entities;
global using ERPBackend.WareHouses.Application.Categories.Features.Register.Interfaces;
global using ERPBackend.WareHouses.Domain.Categories.Interfaces.Repositories;
global using ERPBackend.WareHouses.Domain.Categories.Interfaces.Services;
global using ERPBackend.WareHouses.Application.Categories.Features.Register.UseCases;
global using ERPBackend.WareHouses.Application.Categories.Features.Register.Validators;
global using ERPBackend.WareHouses.Application.Categories.Features.Update.Dtos;
global using ERPBackend.WareHouses.Application.Categories.Features.Update.Interfaces;
global using ERPBackend.WareHouses.Application.Categories.Features.Update.UseCases;
global using ERPBackend.WareHouses.Application.Categories.Features.Update.Validators;
global using ERPBackend.WareHouses.Application.Categories.Features.Delete.Interfaces;
global using ERPBackend.WareHouses.Domain.Categories.Exceptions;
global using ERPBackend.WareHouses.Domain.Categories.ValueObjects;
global using ERPBackend.WareHouses.Application.Categories.Features.Restore.Interfaces;
global using ERPBackend.WareHouses.Application.Categories.Features.Delete.UseCases;
global using ERPBackend.WareHouses.Application.Categories.Features.Restore.UseCases;
global using ERPBackend.WareHouses.Application.Categories.Features.Pagination.Dtos;
global using ERPBackend.SharedKernel.Domain.Paginations;
global using ERPBackend.WareHouses.Application.Categories.Features.Pagination.Interfaces;
global using ERPBackend.WareHouses.Application.Categories.Features.Pagination.UseCases;
global using ERPBackend.WareHouses.Application.Categories.Features.Get.Dtos;
global using ERPBackend.WareHouses.Application.Categories.Features.Get.Interfaces;
global using ERPBackend.WareHouses.Application.Categories.Features.Get.UseCases;
global using ERPBackend.WareHouses.Application.Categories.Features;
global using ERPBackend.WareHouses.Application.Categories;
#endregion

#region Shared
global using ERPBackend.SharedKernel.Validations.Domain.Abstractions;
global using ERPBackend.SharedKernel.Validations.Domain.Interfaces;
global using ERPBackend.SharedKernel.Domain.Exceptions;
global using ERPBackend.SharedKernel.Domain.Interfaces.Repositories;
global using ERPBackend.SharedKernel.Validations.Domain;
global using Microsoft.Extensions.DependencyInjection;
global using ERPBackend.WareHouses.Domain.Core.Interfaces;
#endregion