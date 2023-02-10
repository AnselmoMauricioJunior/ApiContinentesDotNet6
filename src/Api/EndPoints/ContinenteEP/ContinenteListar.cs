using Domain.Interfaces;
using Infra.Repositories;

namespace Api.EndPoints.ContinenteEP;

public class ContinenteListar
{
    public static string Route => "/Continente";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(IContinenteRepository continenteRepository)
    {
        var continentes = continenteRepository.Listar();

        if (continentes == null)
            return Results.BadRequest();

        return Results.Ok(continentes);
    }
}
