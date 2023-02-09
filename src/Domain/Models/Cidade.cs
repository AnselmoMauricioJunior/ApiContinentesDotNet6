using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Models;

public class Cidade : Notifiable<Notification>
{
    public Cidade(string nome, long populacao)
    {
        Nome = nome;
        Populacao = populacao;

        var contract = new Contract<Pais>()
            .IsNotNullOrEmpty(Nome, "Nome", "Nome não pode ser nulo nem vazio!");

        AddNotifications(contract);
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public long Populacao { get; set; }
    public int idEstado { get; set; }

}