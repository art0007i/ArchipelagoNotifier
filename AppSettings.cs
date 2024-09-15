namespace ArchipelagoNotifier;
using Archipelago.MultiClient.Net.Enums;

public class AppSettings
{
    private static AppSettings? _instance;
    public static AppSettings Instance
    {
        get
        {
            if(_instance == null) _instance = new AppSettings();
            return _instance;
        }
        internal set
        {
            _instance = value;
        }
    }

    public static bool ShouldShowItem(ItemFlags item)
    {
        var settings = Instance;
        if (item == ItemFlags.None) return settings.ShowJunk;
        bool result = false;
        if (item.HasFlag(ItemFlags.Advancement)) result |= settings.ShowProgression;
        if (item.HasFlag(ItemFlags.Trap)) result |= settings.ShowTraps;
        if (item.HasFlag(ItemFlags.NeverExclude)) result |= settings.ShowUseful;

        return result;
    }

    public bool ShowTraps = false;
    public bool ShowJunk = false;
    public bool ShowUseful = true;
    public bool ShowProgression = true;
}
