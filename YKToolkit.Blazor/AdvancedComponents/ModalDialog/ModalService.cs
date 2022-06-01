using Microsoft.AspNetCore.Components;

namespace YKToolkit.Blazor;

/// <summary>
/// IModalService インターフェースを実装した機能を提供します。
/// </summary>
public class ModalService : IModalService
{
    /// <summary>
    /// カスタムダイアログを表示します。
    /// </summary>
    /// <param name="contentType">コンテンツコンポーネントの型情報を指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowDialog(Type contentType)
    {
        var content = new RenderFragment(x =>
        {
            x.OpenComponent(1, contentType);
            x.CloseComponent();
        });
        return ShowDialog(content, "", MessageBoxIcon.None, null);
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowDialog(string message)
    {
        return ShowDialog(message, "");
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowDialog(string message, string? title)
    {
        return ShowDialog(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.None, null);
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowDialog(string message, string? title, string?[]? buttonCaptions)
    {
        return ShowDialog(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.None, buttonCaptions);
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowInformationDialog(string message)
    {
        return ShowInformationDialog(message, "情報");
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowInformationDialog(string message, string? title)
    {
        return ShowDialog(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Information, null);
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowInformationDialog(string message, string? title, string?[]? buttonCaptions)
    {
        return ShowDialog(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Information, buttonCaptions);
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowWarningDialog(string message)
    {
        return ShowWarningDialog(message, "警告");
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowWarningDialog(string message, string? title)
    {
        return ShowDialog(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Warning, null);
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowWarningDialog(string message, string? title, string?[]? buttonCaptions)
    {
        return ShowDialog(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Warning, buttonCaptions);
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowErrorDialog(string message)
    {
        return ShowErrorDialog(message, "エラー");
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowErrorDialog(string message, string? title)
    {
        return ShowDialog(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Error, null);
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<bool> ShowErrorDialog(string message, string? title, string?[]? buttonCaptions)
    {
        return ShowDialog(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Error, buttonCaptions);
    }

    /// <summary>
    /// ダイアログを表示します。
    /// </summary>
    /// <param name="content">コンテンツを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="image">ダイアログアイコンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    /// <exception cref="InvalidOperationException">サービスの提供先が存在しない場合に発生します。</exception>
    private async Task<bool> ShowDialog(RenderFragment content, string? title, MessageBoxIcon image, string?[]? buttonCaptions)
    {
        if (this.OnShow is null)
            throw new InvalidOperationException();

        var okButtonCaption = ((buttonCaptions?.Length > 0) && (buttonCaptions[0] is not null)) ? buttonCaptions[0] : "OK";
        var cancelButtonCaption = ((buttonCaptions?.Length > 1) && (buttonCaptions[1] is not null)) ? buttonCaptions[1] : "Cancel";
        var dlg = await this.OnShow.Invoke(content, title, image, new string?[] { okButtonCaption, cancelButtonCaption });

        if (dlg is not null)
        {
            await Task.Run(() =>
            {
                while (dlg.DialogResult is null)
                {
                }
            });
            return dlg.DialogResult.HasValue ? dlg.DialogResult.Value : false;
        }

        return false;
    }

    /// <summary>
    /// ダイアログを表示するときに発生します。
    /// </summary>
    public event Func<RenderFragment, string?, MessageBoxIcon, string?[], Task<ModalDialogBase>>? OnShow;
}
