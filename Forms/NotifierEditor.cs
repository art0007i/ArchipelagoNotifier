namespace ArchipelagoNotifier;

public partial class NotifierEditor : Form
{
    Notifier notifier;

    public NotifierEditor(Notifier notifier)
    {
        this.notifier = notifier;
        InitializeComponent();

        ServerField.Text = notifier.Server;
        NameField.Text = notifier.Name;
        PasswordField.Text = notifier.Password;
    }

    private void ConfirmButton_Click(object sender, EventArgs e)
    {
        notifier.Server = ServerField.Text;
        notifier.Name = NameField.Text;
        notifier.Password = PasswordField.Text;
        DialogResult = DialogResult.OK;
        Close();
    }
}