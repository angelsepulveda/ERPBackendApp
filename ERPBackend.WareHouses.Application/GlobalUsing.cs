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
global using ERPBackend.WareHouses.Application.Categories.Features.Pagination.Interfaces;
global using ERPBackend.WareHouses.Application.Categories.Features.Pagination.UseCases;
global using ERPBackend.WareHouses.Application.Categories.Features.Get.Dtos;
global using ERPBackend.WareHouses.Application.Categories.Features.Get.Interfaces;
global using ERPBackend.WareHouses.Application.Categories.Features.Get.UseCases;
global using ERPBackend.WareHouses.Application.Categories.Features;
global using ERPBackend.WareHouses.Application.Categories;
#endregion

#region Brands
global using ERPBackend.WareHouses.Application.Brands.Features.Delete.Interfaces;
global using ERPBackend.WareHouses.Domain.Brands.Interfaces.Repositories;
global using ERPBackend.WareHouses.Domain.Brands.ValueObjects;
global using ERPBackend.WareHouses.Domain.Brands.Entities;
global using ERPBackend.WareHouses.Application.Brands.Features.Get.Interfaces;
global using ERPBackend.WareHouses.Application.Brands.Features.Pagination.Dtos;
global using ERPBackend.WareHouses.Application.Brands.Features.Pagination.Interfaces;
global using ERPBackend.WareHouses.Application.Brands.Features.Register.Dtos;
global using ERPBackend.WareHouses.Application.Brands.Features.Register.Interfaces;
global using ERPBackend.WareHouses.Domain.Brands.Interfaces.Services;
global using ERPBackend.WareHouses.Domain.Brands.Exceptions;
global using ERPBackend.WareHouses.Application.Brands.Features.Update.Dtos;
global using ERPBackend.WareHouses.Application.Brands.Features.Update.Interfaces;
global using ERPBackend.WareHouses.Application.Brands.Features.Delete.UseCases;
global using ERPBackend.WareHouses.Application.Brands.Features.Get.UseCases;
global using ERPBackend.WareHouses.Application.Brands.Features.Pagination.UseCases;
global using ERPBackend.WareHouses.Application.Brands.Features.Register.UseCases;
global using ERPBackend.WareHouses.Application.Brands.Features.Register.Validators;
global using ERPBackend.WareHouses.Application.Brands.Features.Restore.Interfaces;
global using ERPBackend.WareHouses.Application.Brands.Features.Restore.UseCases;
global using ERPBackend.WareHouses.Application.Brands.Features.Update.UseCases;
global using ERPBackend.WareHouses.Application.Brands.Features.Update.Validators;
global using ERPBackend.WareHouses.Application.Brands.Features;
global using ERPBackend.WareHouses.Application.Brands;
global using ERPBackend.WareHouses.Application.Brands.Features.Get.Dtos;
#endregion

#region Shared
global using ERPBackend.SharedKernel.Validations.Domain.Abstractions;
global using ERPBackend.SharedKernel.Validations.Domain.Interfaces;
global using ERPBackend.SharedKernel.Domain.Exceptions;
global using ERPBackend.SharedKernel.Validations.Domain;
global using Microsoft.Extensions.DependencyInjection;
global using ERPBackend.WareHouses.Domain.Core.Interfaces;
global using ERPBackend.SharedKernel.Domain.Paginations;
#endregion