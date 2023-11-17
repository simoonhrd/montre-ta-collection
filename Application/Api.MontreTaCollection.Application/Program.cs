using Api.MontreTaCollection.Business.Service;
using Api.MontreTaCollection.Business.Service.Contract;
using Api.MontreTaCollection.Data.Context.Contract;
using Api.MontreTaCollection.Data.Entity;
using Api.MontreTaCollection.Data.Repository;
using Api.MontreTaCollection.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Connection to the database 
string connectionString = configuration.GetConnectionString("BddConnection");
builder.Services.AddDbContext<IMontreTaCollectionDBContext, MontreTaCollectionDBContext>(
    options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// IOC of Repositories
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<ICaseMaterialRepository, CaseMaterialRepository>();
builder.Services.AddScoped<IGlassMaterialRepository, GlassMaterialRepository>();
builder.Services.AddScoped<IModelRepository, ModelRepository>();
builder.Services.AddScoped<IMovementTypeRepository, MovementTypeRepository>();
builder.Services.AddScoped<IStrapMaterialRepository, StrapMaterialRepository>();
builder.Services.AddScoped<IWatchRepository, WatchRepository>();
builder.Services.AddScoped<ICommonRepository, CommonRepository>();

// IOC of Services
builder.Services.AddScoped<IWatchService, WatchService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Règle les problème d'erreur CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

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

app.UseCors();

app.Run();
