using Microsoft.AspNetCore.Components;

namespace YKToolkit.Blazor;

/// <summary>
/// ダイアログの機能を提供します。
/// </summary>
public interface IModalService
{
    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowDialog(string message);

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowDialog(string message, string? title);

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowDialog(string message, string? title, string?[] buttonCaptions);

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowInformationDialog(string message);

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowInformationDialog(string message, string? title);

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowInformationDialog(string message, string? title, string?[] buttonCaptions);

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowWarningDialog(string message);

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowWarningDialog(string message, string? title);

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowWarningDialog(string message, string? title, string?[] buttonCaptions);

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowErrorDialog(string message);

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowErrorDialog(string message, string? title);

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<bool> ShowErrorDialog(string message, string? title, string?[] buttonCaptions);

    /// <summary>
    /// ダイアログを表示するときに発生します。
    /// </summary>
    event Func<RenderFragment, string?, MessageBoxIcon, string?[], Task<ModalDialogBase>>? OnShow;
}
