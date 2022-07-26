using YKToolkit.Blazor.Sample.Models;

namespace YKToolkit.Blazor.Sample.ViewModels;

public class ComboBoxViewModel : NotificationObject
{
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
