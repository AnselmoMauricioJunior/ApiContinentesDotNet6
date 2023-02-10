using Domain.Interfaces;
using Infra.Repositories;

namespace Api.EndPoints.ContinenteEP;

public class ContinenteListar
{
    public static string Route => "/Continente";
    public static string[] HttpMethods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handler => Action;

    public static IResult Action(IContinenteRepository continenteRepository)
    {
        var continentes = continenteRepository.Listar();

        if (continentes == null)
            return Results.BadRequest();

        return Results.Ok(continentes);
    }
}
