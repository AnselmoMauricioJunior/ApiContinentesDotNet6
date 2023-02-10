using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Models;

public class Continente : Notifiable<Notification>
{
    public Continente(int id, string nome)
    {
        Id = id;
        Nome = nome;
        ValidarId();
        ValidarNome();
    }
    public Continente(string nome)
    {
        Nome = nome;
        ValidarNome();
    }
    public int Id { get; set; }
    public string Nome { get; set; }

    public void ValidarNome()
    {
        var contract = new Contract<Continente>()
                .IsNotNullOrEmpty(Nome, "Nome", "Nome não pode ser nulo nem vazio!");

        AddNotifications(contract);
    }

    public void ValidarId()
    {
        var contract = new Contract<Continente>()
                .IsGreaterThan(Id, 0, "Id", "Id não pode ser zero!");

        AddNotifications(contract);
    }
}