using Domain.Models;

namespace Domain.Interfaces;

public interface IEstadoRepository
{
    IEnumerable<Estado> Listar();
    Estado Obter(int id);
    void Atualizar(Estado continente);
    void Cadastrar(Estado continente);
}
