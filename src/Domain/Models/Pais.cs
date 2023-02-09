using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Models;

public class Pais : Notifiable<Notification>
{
    public Pais(string nome)
    {
        Nome = nome;

        var contract = new Contract<Pais>()
            .IsNotNullOrEmpty(Nome, "Nome", "Nome não pode ser nulo nem vazio!");

        AddNotifications(contract);
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public int IdContinente { get; set; }
}