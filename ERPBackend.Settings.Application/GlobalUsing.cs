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
#endregion

#region Libreries
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.AspNetCore.Http;
#endregion

#region Shared
global using ERPBackend.SharedKernel.Validations.Domain.Abstractions;
global using ERPBackend.SharedKernel.Validations.Domain.Interfaces;
global using ERPBackend.SharedKernel.Validations.Domain;
global using ERPBackend.SharedKernel.Domain.Results;
global using ERPBackend.SharedKernel.Validations.Domain.ValueObjects;
#endregion