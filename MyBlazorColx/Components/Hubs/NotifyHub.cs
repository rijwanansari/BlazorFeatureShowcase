using Microsoft.AspNetCore.SignalR;

public class NotifyHub : Hub
{
    public async Task SendNotification(string message)
    {
        await Clients.All.SendAsync("ReceiveNotification", message);
    }
}