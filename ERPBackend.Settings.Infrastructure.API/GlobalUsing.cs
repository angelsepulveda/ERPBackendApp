﻿#region Libreries
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
#endregion

#region DocumentTypes
global using ERPBackend.Settings.Application.DocumentTypes.Features.Register.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Register.Interfaces;
global using ERPBackend.Settings.Infrastructure.APÍ.DocumentTypes;
global using ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Delete.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Restore.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Update.Dtos;
global using ERPBackend.Settings.Application.DocumentTypes.Features.Update.Interfaces;
#endregion

#region VoucherTypes
global using ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Register.Dtos;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Register.Interfaces;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Update.Dtos;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Update.Interfaces;
global using ERPBackend.Settings.Application.VoucherTypes.Features.Delete.Interfaces;
global using ERPBackend.Settings.Infrastructure.APÍ.VoucherTypes;
#endregion

#region Address
global using ERPBackend.Settings.Infrastructure.APÍ.Address;

#region Countries
global using ERPBackend.Settings.Application.Address.Countries.Features.Delete.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Get.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Get.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Register.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Register.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Restore.Interfaces;
global using ERPBackend.Settings.Application.Address.Countries.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Countries.Features.Update.Interfaces;
global using ERPBackend.Settings.Infrastructure.APÍ.Address.Countries;
#endregion

#region Regions
global using ERPBackend.Settings.Application.Address.Regions.Features.Delete.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Get.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Get.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Register.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Register.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Restore.Interfaces;
global using ERPBackend.Settings.Application.Address.Regions.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Regions.Features.Update.Interfaces;
global using ERPBackend.Settings.Infrastructure.APÍ.Address.Regions;
#endregion

#region Municipalities
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Delete.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Get.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Get.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Restore.Interfaces;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Dtos;
global using ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Interfaces;
global using ERPBackend.Settings.Infrastructure.APÍ.Address.Municipalities;
#endregion

#endregion