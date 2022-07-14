namespace YKToolkit.Blazor;

/// <summary>
/// ダイアログボタンを表します。
/// </summary>
public enum MessageBoxButton
{
    /// <summary>
    /// OK ボタンのみを表します。
    /// </summary>
    Ok = 0,

    /// <summary>
    /// OK ボタンと Cancel ボタンを表します。
    /// </summary>
    OkCancel,

    /// <summary>
    /// Yes ボタンと No ボタンを表します。
    /// </summary>
    YesNo,

    /// <summary>
    /// Yes ボタンと No ボタンと Cancel ボタンを表します。
    /// </summary>
    YesNoCancel,
}
