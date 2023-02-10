using Api.EndPoints.ContinenteEP;
using Domain.Interfaces;
using Infra.Repositories;

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

app.MapMethods(ContinenteListar.Route, ContinenteListar.HttpMethods, ContinenteListar.Handle);
app.MapMethods(ContinenteObter.Route, ContinenteObter.HttpMethods, ContinenteObter.Handle);
app.MapMethods(ContinenteCadastrar.Route, ContinenteCadastrar.HttpMethods, ContinenteCadastrar.Handle);
app.MapMethods(ContinenteAtualizar.Route, ContinenteAtualizar.HttpMethods, ContinenteAtualizar.Handle);


app.Run();
