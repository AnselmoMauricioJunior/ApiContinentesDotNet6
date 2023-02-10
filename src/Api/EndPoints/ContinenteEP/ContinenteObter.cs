using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.EndPoints.ContinenteEP;

public class ContinenteObter
{
    public static string Route => "/Continente/{id}";
    public static string[] HttpMethods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] int id, IContinenteRepository continenteRepository)
    {
        var continente = continenteRepository.Obter(id);

        if (continente == null)
            return Results.BadRequest();

        return Results.Ok(continente);
    }
}
