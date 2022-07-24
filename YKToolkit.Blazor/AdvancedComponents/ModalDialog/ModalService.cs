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
    public Task<MessageBoxResult> ShowDialogAsync(Type contentType)
    {
        var content = new RenderFragment(x =>
        {
            x.OpenComponent(1, contentType);
            x.CloseComponent();
        });
        return ShowDialogAsync(content, "", MessageBoxIcon.None, MessageBoxButton.OkCancel, null);
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowDialogAsync(string message)
    {
        return ShowDialogAsync(message, "");
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowDialogAsync(string message, string? title)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.None, MessageBoxButton.OkCancel, null);
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowDialogAsync(string message, string? title, MessageBoxButton button)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.None, button, null);
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowDialogAsync(string message, string? title, string?[]? buttonCaptions)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.None, MessageBoxButton.OkCancel, buttonCaptions);
    }

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowDialogAsync(string message, string? title, MessageBoxButton button, string?[]? buttonCaptions)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.None, button, buttonCaptions);
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowInformationDialogAsync(string message)
    {
        return ShowInformationDialogAsync(message, "情報");
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowInformationDialogAsync(string message, string? title)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Information, MessageBoxButton.OkCancel, null);
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowInformationDialogAsync(string message, string? title, MessageBoxButton button)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Information, button, null);
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowInformationDialogAsync(string message, string? title, string?[]? buttonCaptions)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Information, MessageBoxButton.OkCancel, buttonCaptions);
    }

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowInformationDialogAsync(string message, string? title, MessageBoxButton button, string?[]? buttonCaptions)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Information, button, buttonCaptions);
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowWarningDialogAsync(string message)
    {
        return ShowWarningDialogAsync(message, "警告");
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowWarningDialogAsync(string message, string? title)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Warning, MessageBoxButton.OkCancel, null);
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowWarningDialogAsync(string message, string? title, MessageBoxButton button)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Warning, button, null);
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowWarningDialogAsync(string message, string? title, string?[]? buttonCaptions)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Warning, MessageBoxButton.OkCancel, buttonCaptions);
    }

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowWarningDialogAsync(string message, string? title, MessageBoxButton button, string?[]? buttonCaptions)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Warning, button, buttonCaptions);
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowErrorDialogAsync(string message)
    {
        return ShowErrorDialogAsync(message, "エラー");
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowErrorDialogAsync(string message, string? title)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Error, MessageBoxButton.OkCancel, null);
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowErrorDialogAsync(string message, string? title, MessageBoxButton button)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Error, button, null);
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowErrorDialogAsync(string message, string? title, string?[]? buttonCaptions)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Error, MessageBoxButton.OkCancel, buttonCaptions);
    }

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    public Task<MessageBoxResult> ShowErrorDialogAsync(string message, string? title, MessageBoxButton button, string?[]? buttonCaptions)
    {
        return ShowDialogAsync(new RenderFragment(x => x.AddContent(1, message)), title, MessageBoxIcon.Error, button, buttonCaptions);
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
    private async Task<MessageBoxResult> ShowDialogAsync(RenderFragment content, string? title, MessageBoxIcon image, MessageBoxButton button, string[]? buttonCaptions)
    {
        if (this.OnShow is null)
            throw new InvalidOperationException();

        //if (button == MessageBoxButton.Ok)
        var dlg = await this.OnShow.Invoke(content, title, image, button, buttonCaptions);

        if (dlg is not null)
        {
            await Task.Run(() =>
            {
                while (dlg.DialogResult == MessageBoxResult.Undefined)
                {
                }
            });
            return dlg.DialogResult;
        }

        return MessageBoxResult.Undefined;
    }

    /// <summary>
    /// ダイアログを表示するときに発生します。
    /// </summary>
    public event Func<RenderFragment, string?, MessageBoxIcon, MessageBoxButton, string[]?, Task<ModalDialogBase>>? OnShow;
}
