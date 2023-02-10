using Domain.Models;

namespace Domain.Interfaces;

public interface IContinenteRepository
{
    IEnumerable<Continente> Listar();
    Continente Obter(int id);
    void Atualizar(Continente continente);
    void Cadastrar(Continente continente);
}