using Api.Dtos;
using Api.Extensions;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.EndPoints.ContinenteEP;

public class ContinenteAtualizar
{
    public static string Route => "/Continente/{id}";
    public static string[] HttpMethods => new string[] { HttpMethod.Put.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] int id, [FromBody] ContinenteDto continenteDto, IContinenteRepository continenteRepository)
    {
        var continente = new Continente(id, continenteDto.nome);

        if (!continente.IsValid)
            return Results.ValidationProblem(continente.Errors());


        continenteRepository.Atualizar(continente);

        return Results.Ok();
    }
}
