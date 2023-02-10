using Domain.Models;

namespace Domain.Interfaces;

public interface ICidadeRepository
{
    IEnumerable<Cidade> Listar();
    Cidade Obter(int id);
    void Atualizar(Cidade continente);
    void Cadastrar(Cidade continente);
}