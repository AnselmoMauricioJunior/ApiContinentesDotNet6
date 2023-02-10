using Api.Dtos;
using Api.Extensions;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.EndPoints.ContinenteEP;

public class ContinenteCadastrar
{

    public static string Route => "/Continente";
    public static string[] HttpMethods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromBody] ContinenteDto continenteDto, IContinenteRepository continenteRepository)
    {
        var continente = new Continente(continenteDto.nome);

        if (!continente.IsValid)
            return Results.ValidationProblem(continente.Errors());


        continenteRepository.Cadastrar(continente);

        return Results.Ok();
    }
}
