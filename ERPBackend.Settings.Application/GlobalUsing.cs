#region DocumentTypes
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