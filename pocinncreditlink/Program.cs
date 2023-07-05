using Application;
using Application.Interfaces;
using Domain;
using Domain.Interfaces;
using Infraestructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddDbContext<DbinnovacionContext>(options =>
options.UseSqlServer("Server=mssql-co-nop-ingenieria.database.windows.net;Database=dbinnovacion;User Id=dbadmin;Password=m6RdBPgfN)9GTF{2;")
);
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IGenericRepository<Cliente>, GenericRepository<Cliente>>();
builder.Services.AddScoped<IComercioService, ComercioService>();
builder.Services.AddScoped<ICreditoService, CreditoService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


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
