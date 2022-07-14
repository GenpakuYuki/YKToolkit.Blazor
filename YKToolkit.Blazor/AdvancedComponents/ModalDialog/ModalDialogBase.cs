using Microsoft.AspNetCore.Components;

namespace YKToolkit.Blazor;

/// <summary>
/// ダイアログコンポーネントの基本機能を提供します。
/// </summary>
public abstract class ModalDialogBase : ComponentBase
{
    /// <summary>
    /// ダイアログコンポーネントサービスを取得または設定します。
    /// </summary>
    [Inject]
    protected IModalService? ModalService { get; set; }

    /// <summary>
    /// ダイアログタイトルを取得または設定します。
    /// </summary>
    [Parameter]
    public string? Title { get; set; }

    /// <summary>
    /// ダイアログコンテンツを取得または設定します。
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// OK ボタンのキャプションを取得または設定します。
    /// </summary>
    [Parameter]
    public string OkButtonCaption { get; set; } = "OK";

    /// <summary>
    /// Cancel ボタンのキャプションを取得または設定します。
    /// </summary>
    [Parameter]
    public string CancelButtonCaption { get; set; } = "Cancel";

    /// <summary>
    /// Yes ボタンのキャプションを取得または設定します。
    /// </summary>
    [Parameter]
    public string YesButtonCaption { get; set; } = "Yes";

    /// <summary>
    /// No ボタンのキャプションを取得または設定します。
    /// </summary>
    [Parameter]
    public string NoButtonCaption { get; set; } = "No";

    /// <summary>
    /// ダイアログアイコンの種別を取得または設定します。
    /// </summary>
    [Parameter]
    public MessageBoxIcon Image { get; set; }

    /// <summary>
    /// ダイアログの結果を取得または設定します。
    /// </summary>
    [Parameter]
    public MessageBoxResult DialogResult { get; set; }

    protected bool _isOkButtonVisibled;
    protected bool _isCancelButtonVisibled;
    protected bool _isYesButtonVisibled;
    protected bool _isNoButtonVisibled;

    protected string _display = "none";
    protected string _classShow = "";

    /// <summary>
    /// 初期化処理のオーバーライド
    /// </summary>
    protected override void OnInitialized()
    {
        if (this.ModalService is not null)
        {
            this.ModalService.OnShow += ShowDialog;
        }
    }

    /// <summary>
    /// ダイアログを表示します。
    /// </summary>
    /// <param name="content">ダイアログコンテンツを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="image">ダイアログアイコンを指定します。</param>
    /// <param name="button">ダイアログに表示するボタンのパターンを指定します。</param>
    /// <param name="captions">ボタンキャプションを指定します。</param>
    /// <returns>ダイアログオブジェクトを返すタスク。</returns>
    public async Task<ModalDialogBase> ShowDialog(RenderFragment content, string? title, MessageBoxIcon image, MessageBoxButton button, string?[] captions)
    {
        // ToDo: captions の Length が足りない場合はデフォルトの文字列を表示するようにすることで
        //       例外が発生しない柔軟なメソッドにする

        this.DialogResult = MessageBoxResult.Undefined;
        this.ChildContent = content;
        this.Title = title;
        this.Image = image;

        switch (button)
        {
            case MessageBoxButton.Ok:
                if ((captions is null) || (captions.Length == 0))
                {
                    this.OkButtonCaption = OkButtonCaptionDefault;
                }
                else
                {
                    this.OkButtonCaption = captions[0] ?? OkButtonCaptionDefault;
                }

                this._isOkButtonVisibled = true;
                this._isCancelButtonVisibled = false;
                this._isYesButtonVisibled = false;
                this._isNoButtonVisibled = false;
                break;

            case MessageBoxButton.OkCancel:
                if ((captions is null) || (captions.Length == 0))
                {
                    this.OkButtonCaption = OkButtonCaptionDefault;
                }
                else
                {
                    this.OkButtonCaption = captions[0] ?? OkButtonCaptionDefault;
                }

                if ((captions is null) || (captions.Length < 2))
                {
                    this.CancelButtonCaption = CancelButtonCaptionDefault;
                }
                else
                {
                    this.CancelButtonCaption = captions[1] ?? CancelButtonCaptionDefault;
                }

                this._isOkButtonVisibled = true;
                this._isCancelButtonVisibled = true;
                this._isYesButtonVisibled = false;
                this._isNoButtonVisibled = false;
                break;

            case MessageBoxButton.YesNo:
                if ((captions is null) || (captions.Length == 0))
                {
                    this.YesButtonCaption = YesButtonCaptionDefault;
                }
                else
                {
                    this.YesButtonCaption = captions[0] ?? YesButtonCaptionDefault;
                }

                if ((captions is null) || (captions.Length < 2))
                {
                    this.NoButtonCaption = NoButtonCaptionDefault;
                }
                else
                {
                    this.NoButtonCaption = captions[1] ?? NoButtonCaptionDefault;
                }

                this._isOkButtonVisibled = false;
                this._isCancelButtonVisibled = false;
                this._isYesButtonVisibled = true;
                this._isNoButtonVisibled = true;
                break;

            case MessageBoxButton.YesNoCancel:
                if ((captions is null) || (captions.Length == 0))
                {
                    this.YesButtonCaption = YesButtonCaptionDefault;
                }
                else
                {
                    this.YesButtonCaption = captions[0] ?? YesButtonCaptionDefault;
                }

                if ((captions is null) || (captions.Length < 2))
                {
                    this.NoButtonCaption = NoButtonCaptionDefault;
                }
                else
                {
                    this.NoButtonCaption = captions[1] ?? NoButtonCaptionDefault;
                }

                if ((captions is null) || (captions.Length < 3))
                {
                    this.CancelButtonCaption = CancelButtonCaptionDefault;
                }
                else
                {
                    this.CancelButtonCaption = captions[2] ?? CancelButtonCaptionDefault;
                }

                this._isOkButtonVisibled = false;
                this._isCancelButtonVisibled = true;
                this._isYesButtonVisibled = true;
                this._isNoButtonVisibled = true;
                break;
        }

        this._display = "block";
        await Task.Delay(50);
        this._classShow = "show";
        StateHasChanged();

        return this;
    }

    /// <summary>
    /// ダイアログを非表示にします。
    /// </summary>
    /// <returns>戻り値のないタスク。</returns>
    private async Task HideDialog()
    {
        this._classShow = "";
        await Task.Delay(200);
        this._display = "none";
        StateHasChanged();
    }

    /// <summary>
    /// ダイアログ結果決定のためのコールバック処理
    /// </summary>
    /// <param name="result">ダイアログ結果を指定します。</param>
    /// <returns>戻り値のないタスク。</returns>
    protected async Task DialogResultCallback(MessageBoxResult result)
    {
        await HideDialog();
        this.DialogResult = result;
    }

    private const string OkButtonCaptionDefault = "OK";
    private const string CancelButtonCaptionDefault = "Cancel";
    private const string YesButtonCaptionDefault = "Yes";
    private const string NoButtonCaptionDefault = "No";
}
