using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Models;

public class Continente : Notifiable<Notification>
{
    public Continente(string nome)
    {
        Nome = nome; 

        var contract = new Contract<Pais>()
            .IsNotNullOrEmpty(Nome, "Nome", "Nome não pode ser nulo nem vazio!");

        AddNotifications(contract);
    }
    public int Id { get; set; }
    public string Nome { get; set; }
}