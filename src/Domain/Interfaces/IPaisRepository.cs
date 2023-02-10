using Domain.Models;

namespace Domain.Interfaces;

public interface IPaisRepository
{
    IEnumerable<Pais> Listar();
    Pais Obter(int id);
    void Atualizar(Pais continente);
    void Cadastrar(Pais continente);
}
