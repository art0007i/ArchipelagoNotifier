using Archipelago.MultiClient.Net;
using Archipelago.MultiClient.Net.Enums;
using Archipelago.MultiClient.Net.Packets;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Text.Json.Serialization;

namespace ArchipelagoNotifier;

public class Notifier
{
    public enum NotifierStatus
    {
        Disconnected,
        Connecting,
        Connected
    }

    public string? Server { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
    [JsonConstructor]
    public Notifier() : this(null, null, null) { }
    public Notifier(string? server = null, string? name = null, string? password = null)
    {
        Server = server;
        Name = name;
        Password = password;
    }
    public Notifier(Notifier other) : this(other.Server, other.Name, other.Password) { }

    private ArchipelagoSession? session;
    private ListViewItem ourItem = null!;
    private NotifierStatus _status = NotifierStatus.Disconnected;
    private NotifierStatus Status { 
        get => _status;
        set 
        {
            _status = value;
            UpdateViewItem();
        }
    }

    public string GetName()
    {
        return $"{Name}@{Server}";
    }

    public ListViewItem GetViewItem()
    {
        if(ourItem == null)
        {
            var item = new ListViewItem(GetName());
            item.SubItems.Add("unknown");
            ourItem = item;
        }
        return ourItem;
    }

    public async void Disconnect()
    {
        if (session == null)
        {
            return;
        }
        await session.Socket.DisconnectAsync();
    }
    public async void Connect()
    {
        if (session != null)
        {
            return;
        }

        try
        {
            session = ArchipelagoSessionFactory.CreateSession(Server);
            Status = NotifierStatus.Connecting;
            session.Socket.SocketClosed += Socket_SocketClosed;
            session.Socket.PacketReceived += Socket_PacketReceived;

            await session.ConnectAsync();

            var result = await session.LoginAsync(null, Name, ItemsHandlingFlags.RemoteItems, tags: ["Tracker"], password: Password);
            if (!result.Successful)
            {
                session = null;
                var failure = (LoginFailure)result;
                string errorMsg = "";
                foreach (string error in failure.Errors)
                {
                    errorMsg += $"\n    {error}";
                }
                foreach (ConnectionRefusedError error in failure.ErrorCodes)
                {
                    errorMsg += $"\n    {error}";
                }
                throw new Exception(errorMsg);
            }

            Status = NotifierStatus.Connected;
        }
        catch (Exception ex)
        {
            session = null;
            Status = NotifierStatus.Disconnected;
            MessageBox.Show("Failed to connect to archipelago:\n" + ex.ToString());
            return;
        }
    }
    private void Socket_PacketReceived(ArchipelagoPacketBase packet)
    {
        if (this.session == null) return; // should never happen...
        if (packet.PacketType != ArchipelagoPacketType.ReceivedItems) return;

        ReceivedItemsPacket receivedItemsPacket = (ReceivedItemsPacket)packet;
        if (receivedItemsPacket.Index == 0)
        {
            // ignore initial items
            return;
        }
        ArchipelagoSession session = this.session!;
        foreach (var item in receivedItemsPacket.Items)
        {
            if (!AppSettings.ShouldShowItem(item.Flags)) continue;

            var game = session.Players.GetPlayerInfo(item.Player).Game;
            new ToastContentBuilder()
                .AddText("New Item for " + session.Players.ActivePlayer.Alias)
                .AddText($"{session.Items.GetItemName(item.Item)} found in {session.Locations.GetLocationNameFromId(item.Location, game)}")
                .Show();
        }
    }

    private void Socket_SocketClosed(string reason)
    {
        session = null;
        Status = NotifierStatus.Disconnected;
        if (!string.IsNullOrWhiteSpace(reason)) MessageBox.Show("Archipelago session disconnected, reason:\n" + reason);
    }

    public void UpdateViewItem()
    {
        var item = GetViewItem();
        item.Text = GetName();
        item.SubItems[1].Text = _status.ToString();
        switch (_status)
        {
            case NotifierStatus.Disconnected:
                item.SubItems[0].ForeColor = Color.Red;
                break;
            case NotifierStatus.Connecting:
                item.SubItems[0].ForeColor = Color.Orange;
                break;
            case NotifierStatus.Connected:
                item.SubItems[0].ForeColor = Color.Green;
                break;
        }
    }
}
