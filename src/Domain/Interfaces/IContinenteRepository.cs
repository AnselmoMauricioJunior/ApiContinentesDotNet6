using Domain.Models;

namespace Domain.Interfaces;

public interface IContinenteRepository
{
    IEnumerable<Continente> Listar();
    Continente Obter(int id);
    void Atualizar(Continente continente, string nomeUsuario);
    void Cadastrar(Continente continente, string nomeUsuario);
}