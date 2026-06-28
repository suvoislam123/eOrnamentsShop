
using System.Net;
using Bogus;
using BuildingBlocks.Core.Web.Extensions;
using BuildingBlocks.OpenApi.AspnetOpenApi.Extensions;
using BuildingBlocks.OpenApi.AsyncApi;
using eOrnamentsShop.ServiceDefaults.Extensions;
using eOrnamentsShop.Services.Catalogs;
using eOrnamentsShop.Services.Catalogs.Shared.Extensions.HostApplicationBuilderExtensions;
using eOrnamentsShop.Services.Catalogs.Shared.Extensions.WebApplicationExtensions;
using Microsoft.AspNetCore.HttpOverrides;
using Spectre.Console;

AnsiConsole.Write(new FigletText("Catalogs Service").Centered().Color(Color.FromInt32(new Faker().Random.Int(1, 255))));

var builder = WebApplication.CreateBuilder(args);
