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
    /// ダイアログアイコンの種別を取得または設定します。
    /// </summary>
    [Parameter]
    public MessageBoxIcon Image { get; set; }

    /// <summary>
    /// ダイアログの結果を取得または設定します。
    /// </summary>
    [Parameter]
    public bool? DialogResult { get; set; }

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
    /// <param name="captions">ボタンキャプションを指定します。</param>
    /// <returns>ダイアログオブジェクトを返すタスク。</returns>
    /// <exception cref="InvalidOperationException">ボタンキャプションの長さは 2 以上必要です。</exception>
    public async Task<ModalDialogBase> ShowDialog(RenderFragment content, string? title, MessageBoxIcon image, string?[] captions)
    {
        if (captions.Length < 2) throw new InvalidOperationException(nameof(captions));

        this.DialogResult = null;
        this.ChildContent = content;
        this.Title = title;
        this.Image = image;
        var ok = captions[0] ?? "OK";
        var cancel = captions[1] ?? "Cancel";
        this.OkButtonCaption = string.IsNullOrEmpty(ok) ? "OK" : ok;
        this.CancelButtonCaption = string.IsNullOrEmpty(cancel) ? "Cancel" : cancel;

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
    protected async Task DialogResultCallback(bool result)
    {
        await HideDialog();
        this.DialogResult = result;
    }
}
