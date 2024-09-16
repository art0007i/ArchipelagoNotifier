using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArchipelagoNotifier;

public partial class ArchipelagoNotifierManager : Form
{
    Dictionary<ListViewItem, Notifier> notifiers = new();

    public ArchipelagoNotifierManager()
    {
        InitializeComponent();
    }

    #region API
    private void AddNewNotifier(Notifier notifier)
    {
        var newItem = notifier.GetViewItem();
        notifier.UpdateViewItem();
        notifiers.Add(newItem, notifier);
        listView1.Items.Add(newItem);
    }
    private void EditNotifier(Notifier notifier)
    {
        var editForm = new NotifierEditor(notifier);
        if (editForm.ShowDialog() == DialogResult.OK)
        {
            notifier.UpdateViewItem();
        }
    }
    private void EditListItem()
    {
        if (listView1.SelectedItems.Count == 1)
        {
            EditNotifier(notifiers[listView1.SelectedItems[0]]);
        }
    }
    private void DeleteListItems()
    {
        for (int i = listView1.SelectedItems.Count - (1); i >= 0; i--)
        {
            var it = listView1.SelectedItems[i];
            notifiers.Remove(it);
            listView1.Items.Remove(it);
        }
    }
    private void DuplicateListItems()
    {
        for (int i = 0; i < listView1.SelectedItems.Count; i++)
        {
            var it = listView1.SelectedItems[i];
            var notifier = new Notifier(notifiers[it]);
            AddNewNotifier(notifier);
        }
    }
    private void ConnectListItems()
    {
        for (int i = 0; i < listView1.SelectedItems.Count; i++)
        {
            var it = listView1.SelectedItems[i];
            var notifier = notifiers[it];
            notifier.Connect();
        }
    }
    private void DisconnectListItems()
    {
        for (int i = 0; i < listView1.SelectedItems.Count; i++)
        {
            var it = listView1.SelectedItems[i];
            var notifier = notifiers[it];
            notifier.Disconnect();
        }
    }
    #endregion

    #region Tray Icon
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        // Minimize to tray when form is minimized
        if (WindowState == FormWindowState.Minimized)
        {
            ShowInTaskbar = false;
            Visible = false;
        }
    }

    private void TrayIcon_Click(object sender, EventArgs e)
    {
        Visible = true;
        ShowInTaskbar = true;
        WindowState = FormWindowState.Normal;
        Activate();
    }
    #endregion

    #region Data Persistence
    const string DATA_SAVE_PATH = "data.json";
    private void ArchipelagoNotifierManager_Load(object sender, EventArgs e)
    {
        try
        {
            if (!File.Exists(DATA_SAVE_PATH)) return;
            var str = File.ReadAllText(DATA_SAVE_PATH);
            var jo = JObject.Parse(str);
            if (jo["Settings"] is JObject obj)
            {
                var parsedSettings = obj.ToObject<AppSettings>();
                if (parsedSettings != null) AppSettings.Instance = parsedSettings;
            }
            if (jo["Notifiers"] is JArray arr)
            {
                var parsedNotifiers = arr.Select(jt => jt.ToObject<Notifier>()).OfType<Notifier>().ToArray();
                foreach (var item in parsedNotifiers)
                {
                    AddNewNotifier(item);
                }
            }
        }
        catch { }
    }
    private void ArchipelagoNotifierManager_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            var jo = new JObject();
            var settingsObject = JObject.FromObject(AppSettings.Instance);
            jo["Settings"] = settingsObject;
            var notifiersObject = JArray.FromObject(notifiers.Values);
            jo["Notifiers"] = notifiersObject;

            File.WriteAllText(DATA_SAVE_PATH, jo.ToString(Formatting.Indented));
        }
        catch { }
    }
    #endregion

    #region UI Handlers
    private void listView1_DoubleClick(object sender, EventArgs e)
    {
        EditListItem();
    }
    private void listView1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            DeleteListItems();
        }
    }
    private void listView1_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            if (listView1.SelectedItems.Count <= 0) return;
            NotifierMenuStrip.Items[0].Enabled = listView1.SelectedItems.Count == 1;
            NotifierMenuStrip.Show(listView1, e.Location);
        }
    }
    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        EditListItem();
    }
    private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DuplicateListItems();
    }
    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DeleteListItems();
    }
    private void connectToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ConnectListItems();
    }
    private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DisconnectListItems();
    }
    private void AddNewButton_Click(object sender, EventArgs e)
    {
        var notifier = new Notifier();
        AddNewNotifier(notifier);
        EditNotifier(notifier);
    }
    private void ConnectAllButton_Click(object sender, EventArgs e)
    {
        foreach (var item in notifiers)
        {
            item.Value.Connect();
        }
    }
    private void SettingsButton_Click(object sender, EventArgs e)
    {
        var form = new AppSettingsEditor(AppSettings.Instance);
        form.ShowDialog();
    }
    #endregion

}
