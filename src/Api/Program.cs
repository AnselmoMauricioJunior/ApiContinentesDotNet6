using Api.Dtos;
using Api.EndPoints.ContinenteEP;
using Domain.Interfaces;
using Domain.Models;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IContinenteRepository, ContinenteRepository>();
builder.Services.AddScoped<IPaisRepository, PaisRepository>();
builder.Services.AddScoped<IEstadoRepository, EstadoRepository>();
builder.Services.AddScoped<ICidadeRepository, CidadeRepository>();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapMethods(ContinenteListar.Route, ContinenteListar.Methods, ContinenteListar.Handle);
app.MapMethods(ContinenteObter.Route, ContinenteObter.Methods, ContinenteObter.Handle);
app.MapMethods(ContinenteCadastrar.Route, ContinenteCadastrar.Methods, ContinenteCadastrar.Handle);


app.Run();
