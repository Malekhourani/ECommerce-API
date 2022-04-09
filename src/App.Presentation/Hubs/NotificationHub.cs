using Microsoft.AspNetCore.SignalR;

namespace App.Presentation.Hubs;

public class NotificationHub : Hub
{
    public async Task NotifiyAuctionMembers(string auctionId, string username, double price)
    {
        await Clients.Group(auctionId).SendAsync("NewOfferReceived", $"{username} gives a new offer, and its value is {price}!");
    }
    public async Task AddToAuctionGroup(string groupName)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

        await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the auction.");
    }
    public async Task RemoveFromAuctionGroup(string groupName)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);

        await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has left the auction.");
    }
}
