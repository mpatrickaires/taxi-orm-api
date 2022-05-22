using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Context;
using TaxiOrmApi.Models;
using TaxiOrmApi.Repositories;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services;
using TaxiOrmApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );

builder.Services.AddDbContext<AppDbContext>(options => options
        .UseNpgsql(configuration.GetConnectionString("TaxiOrmApi"))
        .UseSnakeCaseNamingConvention()
    );

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DbContext, AppDbContext>();

// Base Services
builder.Services.AddScoped<IRepositoryBase<Entity>, RepositoryBase<Entity>>();
builder.Services.AddScoped<IServiceBase<Entity>, ServiceBase<Entity>>();

// Specialized Services
builder.Services.AddScoped<IFabricanteRepository, FabricanteRepository>();
builder.Services.AddScoped<IFabricanteService, FabricanteService>();
builder.Services.AddScoped<IModeloRepository, ModeloRepository>();
builder.Services.AddScoped<IModeloService, ModeloService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
