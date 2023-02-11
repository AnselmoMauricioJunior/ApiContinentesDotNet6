using Api.EndPoints.ContinenteEP;
using Api.EndPoints.TokenEP;
using Api.Extensions;
using Domain.Interfaces;
using Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfiguration();

builder.Services.AddScoped<IContinenteRepository, ContinenteRepository>();
builder.Services.AddScoped<IPaisRepository, PaisRepository>();
builder.Services.AddScoped<IEstadoRepository, EstadoRepository>();
builder.Services.AddScoped<ICidadeRepository, CidadeRepository>();

builder.Services.AddAuthorization();
builder.Services.AddJwtConfiguration(builder.Configuration);

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapMethods(ContinenteListar.Route, ContinenteListar.HttpMethods, ContinenteListar.Handle);
app.MapMethods(ContinenteObter.Route, ContinenteObter.HttpMethods, ContinenteObter.Handle);
app.MapMethods(ContinenteCadastrar.Route, ContinenteCadastrar.HttpMethods, ContinenteCadastrar.Handle);
app.MapMethods(ContinenteAtualizar.Route, ContinenteAtualizar.HttpMethods, ContinenteAtualizar.Handle);

app.MapMethods(TokenGerar.Route, TokenGerar.HttpMethods, TokenGerar.Handle);


app.Run();
