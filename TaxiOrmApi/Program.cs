using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaxiOrmApi.Context;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models;
using TaxiOrmApi.Repositories;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services;
using TaxiOrmApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddDbContext<AppDbContext>(options => options
        .UseNpgsql(builder.Configuration.GetConnectionString("TaxiOrmApi"))
        .UseSnakeCaseNamingConvention()
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DbContext, AppDbContext>();

builder.Services.AddScoped<IRepositoryBase<Entity>, RepositoryBase<Entity>>();
builder.Services.AddScoped<IServiceBase<Entity, EntityDto>, ServiceBase<Entity, EntityDto>>();

builder.Services.AddScoped<IFabricanteRepository, FabricanteRepository>();
builder.Services.AddScoped<IFabricanteService, FabricanteService>();
builder.Services.AddScoped<IModeloRepository, ModeloRepository>();
builder.Services.AddScoped<IModeloService, ModeloService>();

// Configuring AutoMapper.
var mapperConfig = new MapperConfiguration(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));
var mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

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
