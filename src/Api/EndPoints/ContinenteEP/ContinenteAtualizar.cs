using Api.Dtos;
using Api.Extensions;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Api.EndPoints.ContinenteEP;

public class ContinenteAtualizar
{
    public static string Route => "/Continente/{id}";
    public static string[] HttpMethods => new string[] { HttpMethod.Put.ToString() };
    public static Delegate Handle => Action;

    [Authorize]
    public static IResult Action(
        [FromRoute] int id,
        [FromBody] ContinenteDto continenteDto,
        IContinenteRepository continenteRepository, HttpContext http)
    {
        var nomeUsuario = http.User.Claims.First(c => c.Type == ClaimTypes.Name).Value;
        var continente = new Continente(id, continenteDto.nome);

        if (!continente.IsValid)
            return Results.ValidationProblem(continente.Errors());


        continenteRepository.Atualizar(continente, nomeUsuario);

        return Results.Ok();
    }
}
