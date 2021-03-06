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

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddDbContext<AppDbContext>(options => options
        .UseNpgsql(builder.Configuration.GetConnectionString("TaxiOrmApi"))
        .UseSnakeCaseNamingConvention()
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DbContext, AppDbContext>();

builder.Services.AddScoped<IGenericRepository<Entity>, GenericRepository<Entity>>();
builder.Services.AddScoped<IGenericService<EntityDto>, GenericService<Entity, EntityDto>>();

builder.Services.AddScoped<IFabricanteRepository, FabricanteRepository>();
builder.Services.AddScoped<IFabricanteService, FabricanteService>();

builder.Services.AddScoped<IModeloRepository, ModeloRepository>();
builder.Services.AddScoped<IModeloService, ModeloService>();

builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IVeiculoService, VeiculoService>();

builder.Services.AddScoped<IMotoristaRepository, MotoristaRepository>();
builder.Services.AddScoped<IMotoristaService, MotoristaService>();

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();

builder.Services.AddScoped<ITelefoneClienteRepository, TelefoneClienteRepository>();
builder.Services.AddScoped<ITelefoneClienteService, TelefoneClienteService>();

builder.Services.AddScoped<ILocalizacaoRepository, LocalizacaoRepository>();
builder.Services.AddScoped<ILocalizacaoService, LocalizacaoService>();

builder.Services.AddScoped<ISolicitacaoRepository, SolicitacaoRepository>();
builder.Services.AddScoped<ISolicitacaoService, SolicitacaoService>();


// Configuring AutoMapper.
var mapperConfig = new MapperConfiguration(cfg =>
    cfg.AddMaps(Assembly.GetExecutingAssembly())
);
var mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
