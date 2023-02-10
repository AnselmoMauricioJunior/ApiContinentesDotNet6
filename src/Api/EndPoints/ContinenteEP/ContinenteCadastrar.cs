using Api.Dtos;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.EndPoints.ContinenteEP;

public class ContinenteCadastrar
{

    public static string Route => "/Continente";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromBody] ContinenteDto continenteDto, IContinenteRepository continenteRepository)
    {
        var continente = new Continente(continenteDto.nome);

        if (!continente.IsValid)
        {
            var erros = continente.Notifications
                            .GroupBy(g => g.Key)
                            .ToDictionary(g => g.Key, g => g.Select(x => x.Message).ToArray());

            return Results.ValidationProblem(erros);
        }

        continenteRepository.Cadastrar(continente);

        return Results.Ok();
    }
}
