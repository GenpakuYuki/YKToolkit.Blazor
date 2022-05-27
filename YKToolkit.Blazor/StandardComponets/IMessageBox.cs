public enum MessageBoxIcon
{
    None = 0,
    Information,
    Warning,
    Error,
}

public interface IMessageBoxService
{
    Task<bool> ShowDialog(string message, string title);
    Task<bool> ShowInformationDialog(string message, string title);
    Task<bool> ShowWarningDialog(string message, string title);
    Task<bool> ShowErrorDialog(string message, string title);

    bool IsDialogVisible { get; }

    string? Title { get; }

    string? Message { get; }

    MessageBoxIcon Image { get; }

    void DialogResultCallback(bool result);
}
