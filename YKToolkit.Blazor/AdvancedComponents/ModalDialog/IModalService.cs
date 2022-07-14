using Microsoft.AspNetCore.Components;

namespace YKToolkit.Blazor;

/// <summary>
/// ダイアログの機能を提供します。
/// </summary>
public interface IModalService
{
    /// <summary>
    /// カスタムダイアログを表示します。
    /// </summary>
    /// <param name="contentType">コンテンツコンポーネントの型情報を指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowDialog(Type contentType);

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowDialog(string message);

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowDialog(string message, string? title);

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowDialog(string message, string? title, MessageBoxButton button);

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowDialog(string message, string? title, string?[] buttonCaptions);

    /// <summary>
    /// メッセージダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowDialog(string message, string? title, MessageBoxButton button, string?[] buttonCaptions);

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowInformationDialog(string message);

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowInformationDialog(string message, string? title);

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowInformationDialog(string message, string? title, MessageBoxButton button);

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowInformationDialog(string message, string? title, string?[] buttonCaptions);

    /// <summary>
    /// インフォメーションダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowInformationDialog(string message, string? title, MessageBoxButton button, string?[] buttonCaptions);

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowWarningDialog(string message);

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowWarningDialog(string message, string? title);

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowWarningDialog(string message, string? title, MessageBoxButton button);

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowWarningDialog(string message, string? title, string?[] buttonCaptions);

    /// <summary>
    /// 警告ダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowWarningDialog(string message, string? title, MessageBoxButton button, string?[] buttonCaptions);

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowErrorDialog(string message);

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowErrorDialog(string message, string? title);

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowErrorDialog(string message, string? title, MessageBoxButton button);

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowErrorDialog(string message, string? title, string?[] buttonCaptions);

    /// <summary>
    /// エラーダイアログを表示します。
    /// </summary>
    /// <param name="message">メッセージを指定します。</param>
    /// <param name="title">ダイアログタイトルを指定します。</param>
    /// <param name="button">表示するボタンを指定します。</param>
    /// <param name="buttonCaptions">ボタンのキャプションを指定します。</param>
    /// <returns>ダイアログ結果を返すタスク。</returns>
    Task<MessageBoxResult> ShowErrorDialog(string message, string? title, MessageBoxButton button, string?[] buttonCaptions);

    /// <summary>
    /// ダイアログを表示するときに発生します。
    /// </summary>
    event Func<RenderFragment, string?, MessageBoxIcon, MessageBoxButton, string[]?, Task<ModalDialogBase>>? OnShow;
}
