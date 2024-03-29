// Global using directives

global using System.Reflection;
global using AutoMapper;
global using FluentValidation;
global using FluentValidation.Results;
global using MCL.Application.Contracts.Persistence;
global using MCL.Application.DTOs;
global using MCL.Application.DTOs.Common;
global using MCL.Application.DTOs.LeaveAllocation;
global using MCL.Application.DTOs.LeaveAllocation.Validators;
global using MCL.Application.DTOs.LeaveRequest;
global using MCL.Application.DTOs.LeaveRequest.Validators;
global using MCL.Application.DTOs.LeaveType;
global using MCL.Application.DTOs.LeaveType.Validators;
global using MCL.Application.Features.LeaveAllocations.Requests.Commands;
global using MCL.Application.Features.LeaveAllocations.Requests.Queries;
global using MCL.Application.Features.LeaveRequests.Requests.Commands;
global using MCL.Application.Features.LeaveRequests.Requests.Queries;
global using MCL.Application.Features.LeaveTypes.Requests;
global using MCL.Application.Features.LeaveTypes.Requests.Commands;
global using MCL.Application.Features.LeaveTypes.Requests.Queries;
global using MCL.Application.Models;
global using MCL.Application.Responses;
global using MCL.Domain;
global using MediatR;
global using Microsoft.Extensions.DependencyInjection;