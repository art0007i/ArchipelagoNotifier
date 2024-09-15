namespace ArchipelagoNotifier;

public partial class AppSettingsEditor : Form
{
    AppSettings settings;

    public AppSettingsEditor(AppSettings settings)
    {
        this.settings = settings;
        InitializeComponent();

        TrapCheckbox.Checked = settings.ShowTraps;
        JunkCheckbox.Checked = settings.ShowJunk;
        UsefulCheckbox.Checked = settings.ShowUseful;
        ProgressionCheckbox.Checked = settings.ShowProgression;
    }
    private void ConfirmButton_Click(object sender, EventArgs e)
    {
        settings.ShowTraps = TrapCheckbox.Checked;
        settings.ShowJunk = JunkCheckbox.Checked;
        settings.ShowUseful = UsefulCheckbox.Checked;
        settings.ShowProgression = ProgressionCheckbox.Checked;
        DialogResult = DialogResult.OK;
        Close();
    }
}
