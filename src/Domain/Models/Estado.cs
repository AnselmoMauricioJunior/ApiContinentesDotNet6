using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Models;

public class Estado : Notifiable<Notification>
{
    public Estado(string nome, string uf)
    {
        Nome = nome;
        UF = uf;

        var contract = new Contract<Pais>()
            .IsNotNullOrEmpty(Nome, "Nome", "Nome não pode ser nulo nem vazio!")
            .IsNotNullOrEmpty(UF, "UF", "UF não pode ser nulo nem vazio")
            .IsGreaterOrEqualsThan(UF, 2, "UF", "UF não pode ter menos que 2 caracteres")
            .IsLowerOrEqualsThan(UF, 2, "UF");

        AddNotifications(contract);
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string UF { get; set; }
    public int idPais { get; set; }

}
