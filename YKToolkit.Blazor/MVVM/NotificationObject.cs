using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// System.ComponentModel.INotifyPropertyChanged インターフェースを実装したプロパティ変更通知機能を提供します。
/// </summary>
public class NotificationObject : INotifyPropertyChanged
{
    /// <summary>
    /// プロパティが変更されたときに発生します。
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// PropertyChanged イベントを発行します。
    /// </summary>
    /// <param name="propertyName">プロパティ値が変更されたプロパティ名を指定します。</param>
    protected void RaisePropertyChanged([CallerMemberName]string? propertyName = null) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    /// <summary>
    /// プロパティ値変更用ヘルパです。
    /// </summary>
    /// <param name="target">対象とするプロパティの実体を指定します。</param>
    /// <param name="value">変更後の値を指定します。</param>
    /// <param name="propertyName">プロパティ名を指定します。</param>
    /// <typeparam name="T">プロパティの型を表します。</typeparam>
    /// <returns>プロパティ値に変更があった場合に true を返します。</returns>
    protected bool SetProperty<T>(ref T target, T value, [CallerMemberName]string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(target, value))
            return false;
        target = value;
        RaisePropertyChanged(propertyName);
        return true;
    }
}