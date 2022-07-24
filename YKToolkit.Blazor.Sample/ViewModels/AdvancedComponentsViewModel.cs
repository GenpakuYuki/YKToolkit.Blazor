namespace YKToolkit.Blazor.Sample.ViewModels;

/// <summary>
/// Advanced コンポーネントに対する ViewModel を表します。
/// </summary>
public class AdvancedComponentsViewModel : NotificationObject
{
    /// <summary>
    /// 新しいインスタンスを生成します。
    /// </summary>
    /// <param name="modalService"></param>
    public AdvancedComponentsViewModel(IModalService modalService)
    {
        this._modalService = modalService;

        this.ShowMessageCommand = new DelegateCommand(_ => ShowMessage());
        this.ShowInformationCommand = new DelegateCommand(_ => ShowInformation());
        this.ShowWarningCommand = new DelegateCommand(_ => ShowWarning());
        this.ShowErrorCommand = new DelegateCommand(_ => ShowError());
        this.ShowDialogCommand = new DelegateCommand(p => ShowDialog((Type?)p));
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    private async void ShowMessage()
    {
        if (string.IsNullOrEmpty(this.Message))
        {
            await this._modalService.ShowErrorDialogAsync("メッセージを入力してください。");
        }
        else
        {
            this.DialogResult = await this._modalService.ShowDialogAsync(this.Message, this.DialogTitle, this.ButtonCaptions);
        }
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    private async void ShowInformation()
    {
        if (string.IsNullOrEmpty(this.Message))
        {
            await this._modalService.ShowErrorDialogAsync("メッセージを入力してください。");
        }
        else
        {
            this.DialogResult = await this._modalService.ShowInformationDialogAsync(this.Message, this.DialogTitle, this.ButtonCaptions);
        }
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    private async void ShowWarning()
    {
        if (string.IsNullOrEmpty(this.Message))
        {
            await this._modalService.ShowErrorDialogAsync("メッセージを入力してください。");
        }
        else
        {
            this.DialogResult = await this._modalService.ShowWarningDialogAsync(this.Message, this.DialogTitle, this.ButtonCaptions);
        }
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    private async void ShowError()
    {
        if (string.IsNullOrEmpty(this.Message))
        {
            await this._modalService.ShowErrorDialogAsync("メッセージを入力してください。");
        }
        else
        {
            this.DialogResult = await this._modalService.ShowErrorDialogAsync(this.Message, this.DialogTitle, this.ButtonCaptions);
        }
    }

    /// <summary>
    /// カスタムダイアログを表示します。
    /// </summary>
    /// <param name="type"></param>
    private async void ShowDialog(Type? type)
    {
        if (type == null) return;

        this.SampleDialogResult = await this._modalService.ShowDialogAsync(type);
    }

    /// <summary>
    /// メッセージダイアログ表示コマンドを取得します。
    /// </summary>
    public DelegateCommand ShowMessageCommand { get; private set; }

    /// <summary>
    /// インフォメーションダイアログ表示コマンドを取得します。
    /// </summary>
    public DelegateCommand ShowInformationCommand { get; private set; }

    /// <summary>
    /// 警告ダイアログ表示コマンドを取得します。
    /// </summary>
    public DelegateCommand ShowWarningCommand { get; private set; }

    /// <summary>
    /// エラーダイアログ表示コマンドを取得します。
    /// </summary>
    public DelegateCommand ShowErrorCommand { get; private set; }

    /// <summary>
    /// カスタムダイアログ表示コマンドを取得します。
    /// </summary>
    public DelegateCommand ShowDialogCommand { get; private set; }

    /// <summary>
    /// ダイアログメッセージを取得または設定します。
    /// </summary>
    public string? Message { get; set; } = "メッセージです。";

    /// <summary>
    /// ダイアログタイトルを取得または設定します。
    /// </summary>
    public string? DialogTitle { get; set; }

    /// <summary>
    /// ダイアログの OK ボタンのキャプションを取得または設定します。
    /// </summary>
    public string? OkButtonCaption { get; set; }

    /// <summary>
    /// ダイアログの Cancel ボタンのキャプションを取得または設定します。
    /// </summary>
    public string? CancelButtonCaption { get; set; }

    /// <summary>
    /// ダイアログのボタンキャプションを取得します。
    /// </summary>
    private string?[] ButtonCaptions { get => new string?[] { this.OkButtonCaption, this.CancelButtonCaption }; }

    private MessageBoxResult _dialogResult;
    /// <summary>
    /// ダイアログ結果を取得または設定します。
    /// </summary>
    public MessageBoxResult DialogResult
    {
        get => this._dialogResult;
        set => SetProperty(ref this._dialogResult, value);
    }

    private MessageBoxResult _sampleDialogResult;
    /// <summary>
    /// カスタムダイアログ結果を取得または設定します。
    /// </summary>
    public MessageBoxResult SampleDialogResult
    {
        get => this._sampleDialogResult;
        set => SetProperty(ref this._sampleDialogResult, value);
    }

    /// <summary>
    /// ダイアログ表示用サービス
    /// </summary>
    private IModalService _modalService;
}
