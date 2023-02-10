using Flunt.Notifications;

namespace Api.Extensions;

public static class NoticationsErrorsResponse
{
    public static Dictionary<string, string[]> Errors(this Notifiable<Notification> notifiable)
    {

        return notifiable.Notifications
                                .GroupBy(g => g.Key)
                                .ToDictionary(g => g.Key, g => g.Select(x => x.Message).ToArray());
    }
}
