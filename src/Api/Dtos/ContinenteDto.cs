using Domain.Models;

namespace Api.Dtos;

public record ContinenteDto(string nome);

public static class ContinenteUtils
{
    public static Continente ToModel(this ContinenteDto continenteDto)
    {
        return new Continente(continenteDto.nome);
    }
}
