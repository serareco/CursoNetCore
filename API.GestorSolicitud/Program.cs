using API.GestorSolicitud.IServices;
using API.GestorSolicitud.Services;
using Data;
using Logic.ILogic;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISolicitudService, SolicitudService>();

builder.Services.AddScoped<ISolicitudLogic, SolicitudLogic>();
builder.Services.AddDbContext<ServiceContext>(
        options => options.UseOracle("name=ConnectionStrings:ServiceContext"));

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
