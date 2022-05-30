using YKToolkit.Blazor.Sample.Models;

namespace YKToolkit.Blazor.Sample.ViewModels;

/// <summary>
/// Standard コンポーネントに対する ViewModel を表します。
/// </summary>
public class StandardComponentsViewModel : NotificationObject
{
    /// <summary>
    /// 新しいインスタンスを生成します。
    /// </summary>
    public StandardComponentsViewModel()
    {
        this.SampleCommand = new DelegateCommand(_ => Sample());
    }

    /// <summary>
    /// サンプルコマンドから実行されます。
    /// </summary>
    private void Sample()
    {
        System.Diagnostics.Debug.WriteLine("Sample()");
    }

    /// <summary>
    /// サンプルコマンドを取得します。
    /// </summary>
    public DelegateCommand SampleCommand { get; private set; }

    private bool _isChecked = true;
    /// <summary>
    /// チェックボックス状態を取得または設定します。
    /// </summary>
    public bool IsChecked
    {
        get => this._isChecked;
        set
        { 
            System.Diagnostics.Debug.WriteLine(value);
            SetProperty(ref this._isChecked, value);
        }
    }

    /// <summary>
    /// ボタンの操作状態を取得または設定します。
    /// </summary>
    public bool IsButtonEnabled { get; set; }

    /// <summary>
    /// 数値コレクションを取得します。
    /// </summary>
    public IEnumerable<int> Numbers { get; } = Enumerable.Range(0, 5).ToArray();

    /// <summary>
    /// 人物情報コレクションを取得します。
    /// </summary>
    public IEnumerable<Person> Persons { get; } = Enumerable.Range(0, 5).Select(x => new Person() { Name = $"太郎 {x}", Age = x }).ToArray();

    private Person? _selectedPerson;
    /// <summary>
    /// 選択中の人物情報を取得または設定します。
    /// </summary>
    public Person? SelectedPerson
    {
        get => this._selectedPerson;
        set
        {
            if (SetProperty(ref this._selectedPerson, value))
            {
                System.Diagnostics.Debug.WriteLine(this._selectedPerson?.Name);
            }
        }
    }
}
