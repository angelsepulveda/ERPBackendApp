﻿#region DocumentTypes
global using ERPBackend.Settings.Application.DocumentTypes.Features.Register.Dtos;
global using ERPBackend.Settings.Domain.DocumentTypes.Entities;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;
global using ERPBackend.SharedKernel.Domain.Interfaces.Repositories;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Register.UseCases;
global using ERPBackend.Settings.Application.DocumentTypes.Features;
global using ERPBackend.Settings.Application.DocumentTypes;
global using ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.UseCases;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Delete.Interfaces;
global using ERPBackend.Settings.Domain.DocumentTypes.Exceptions;
global using ERPBackend.Settings.Domain.DocumentTypes.ValueObjects;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Delete.UseCases;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Restore.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Restore.UseCases;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Register.Validators;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Update.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.UseCases;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Update.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Update.UseCases;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Update.Validators;
#endregion

#region VoucherTypes
global using ERPBackend.Settings.Application.VoucherTypes.Features.Register.Dtos;
global using ERPBackend.Settings.Domain.VoucherTypes.Entities;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.VoucherTypes.Interfaces.Repositories;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Register.UseCases;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Register.Validators;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.UseCases;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Update.Dtos;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Update.Interfaces;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Update.UseCases;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Update.Validators;
global using ERPBackend.Settings.Domain.VoucherTypes.ValueObjects;
global using ERPBackend.Settings.Domain.VoucherTypes.Exceptions;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Delete.Interfaces;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Delete.UseCases;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Restore.Interfaces;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Restore.UseCases;
global using ERPBackend.Settings.Application.VoucherTypes.Features;
global using ERPBackend.Settings.Application.VoucherTypes;
#endregion

#region Libreries
global using Microsoft.Extensions.DependencyInjection;
#endregion

#region Shared
global using ERPBackend.SharedKernel.Validations.Domain.Abstractions;
global using ERPBackend.SharedKernel.Validations.Domain.Interfaces;
global using ERPBackend.SharedKernel.Validations.Domain;
global using ERPBackend.SharedKernel.Domain.Paginations;
global using ERPBackend.SharedKernel.Domain.Exceptions;
#endregion

#region Address
global using ERPBackend.Settings.Application.Address;

#region Countries
global using ERPBackend.Settings.Application.Address.Countries.Features.Delete.Interfaces;
global using ERPBackend.Settings.Domain.Address.Countries.Exceptions;
global using ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;
global using ERPBackend.Settings.Domain.Address.Countries.ValueObjects;
global using ERPBackend.Settings.Application.Address.Countries.Features.Restore.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Register.Dtos;
global using ERPBackend.Settings.Domain.Address.Countries.Entities;
global using ERPBackend.Settings.Application.Address.Countries.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.Address.Countries.Interfaces.Services;
global using ERPBackend.Settings.Application.Address.Countries.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Update.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Get.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Delete.UseCases;
global using ERPBackend.Settings.Application.Address.Countries.Features.Get.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Get.UseCases;
global using ERPBackend.Settings.Application.Address.Countries.Features.Pagination.UseCases;
global using ERPBackend.Settings.Application.Address.Countries.Features.Register.UseCases;
global using ERPBackend.Settings.Application.Address.Countries.Features.Restore.UseCases;
global using ERPBackend.Settings.Application.Address.Countries.Features.Update.UseCases;
global using ERPBackend.Settings.Application.Address.Countries.Features;
global using ERPBackend.Settings.Application.Address.Countries;
#endregion

#region Regions
global using ERPBackend.Settings.Application.Address.Regions.Features.Delete.Interfaces;
global using ERPBackend.Settings.Domain.Address.Regions.Exceptions;
global using ERPBackend.Settings.Domain.Address.Regions.Interfaces.Repositories;
global using ERPBackend.Settings.Domain.Address.Regions.ValueObjects;
global using ERPBackend.Settings.Application.Address.Regions.Features.Restore.Interfaces;
global using ERPBackend.Settings.Domain.Address.Regions.Entities;
global using ERPBackend.Settings.Application.Address.Regions.Features.Get.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Register.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.Address.Regions.Interfaces.Services;
global using ERPBackend.Settings.Application.Address.Regions.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Update.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Delete.UseCases;
global using ERPBackend.Settings.Application.Address.Regions.Features.Get.UseCases;
global using ERPBackend.Settings.Application.Address.Regions.Features.Pagination.UseCases;
global using ERPBackend.Settings.Application.Address.Regions.Features.Register.UseCases;
global using ERPBackend.Settings.Application.Address.Regions.Features.Restore.UseCases;
global using ERPBackend.Settings.Application.Address.Regions.Features.Update.UseCases;
global using ERPBackend.Settings.Application.Address.Regions.Features;
global using ERPBackend.Settings.Application.Address.Regions;
#endregion

#region Municipalities
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Delete.Interfaces;
global using ERPBackend.Settings.Domain.Address.Municipalities.Exceptions;
global using ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;
global using ERPBackend.Settings.Domain.Address.Municipalities.ValueObjects;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Get.Dtos;
global using ERPBackend.Settings.Domain.Address.Municipalities.Entities;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Get.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Services;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Restore.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Delete.UseCases;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Get.UseCases;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.UseCases;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Register.UseCases;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Restore.UseCases;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Update.UseCases;
global using ERPBackend.Settings.Application.Address.Municipalities.Features;
global using ERPBackend.Settings.Application.Address.Municipalities;
#endregion

#endregion