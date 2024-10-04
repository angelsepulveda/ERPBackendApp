#region DocumentTypes
global using ERPBackend.Settings.Application.DocumentTypes.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.DocumentTypes.Entities;
global using ERPBackend.Settings.Infrastructure.Presenters.DocumentTypes;
global using ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Update.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Update.Interfaces;
#endregion

#region VoucherTypes
global using ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Domain.VoucherTypes.Entities;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Register.Interfaces;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Update.Dtos;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Update.Interfaces;
global using ERPBackend.Settings.Infrastructure.Presenters.VoucherTypes;
#endregion

#region Libreries
global using Microsoft.Extensions.DependencyInjection;
global using ERPBackend.SharedKernel.Domain.Paginations;
#endregion

#region Address
global using ERPBackend.Settings.Infrastructure.Presenters.Address;

#region Countries
global using ERPBackend.Settings.Application.Address.Countries.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.Address.Countries.Entities;
global using ERPBackend.Settings.Application.Address.Countries.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Update.Interfaces;
global using ERPBackend.Settings.Infrastructure.Presenters.Address.Countries;
global using ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Get.Interfaces;
#endregion

#region Regions
global using ERPBackend.Settings.Application.Address.Regions.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.Address.Regions.Entities;
global using ERPBackend.Settings.Application.Address.Regions.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Update.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Get.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Get.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Infrastructure.Presenters.Address.Regions;
#endregion

#region Municipalities
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Interfaces;
global using ERPBackend.Settings.Domain.Address.Municipalities.Entities;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Get.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Get.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Infrastructure.Presenters.Address.Municipalities;
#endregion

#endregion
