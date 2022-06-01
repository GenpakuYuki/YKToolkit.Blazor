namespace YKToolkit.Blazor.Sample.ViewModels;

/// <summary>
/// SampleDialog コンポーネントに対する ViewModel を表します。
/// </summary>
public class SampleDialogViewModel : NotificationObject
{
    /// <summary>
    /// 新しいインスタンスを生成します。
    /// </summary>
    public SampleDialogViewModel()
    {
        this.IncrementCommand = new DelegateCommand(_ => Increment());
    }

    /// <summary>
    /// カウント値をインクリメントします。
    /// </summary>
    private void Increment()
    {
        this.Count++;
    }

    /// <summary>
    /// インクリメントコマンドを取得します。
    /// </summary>
    public DelegateCommand IncrementCommand { get; private set; }

    private int _count;
    /// <summary>
    /// カウント値を取得または設定します。
    /// </summary>
    public int Count
    {
        get => this._count;
        set => SetProperty(ref this._count, value);
    }

    /// <summary>
    /// サンプル用のテキストを取得します。
    /// </summary>
    public string Title { get; } = "デモンストレーション";
}
