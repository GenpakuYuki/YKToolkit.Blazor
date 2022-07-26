using YKToolkit.Blazor.Sample.Models;

namespace YKToolkit.Blazor.Sample.ViewModels;

public class ItemsControlViewModel : NotificationObject
{
    /// <summary>
    /// 数値コレクションを取得します。
    /// </summary>
    public IEnumerable<int> Numbers { get; } = Enumerable.Range(0, 5).ToArray();

    /// <summary>
    /// 人物情報コレクションを取得します。
    /// </summary>
    public IEnumerable<Person> Persons { get; } = Enumerable.Range(0, 5).Select(x => new Person() { Name = $"太郎 {x}", Age = x }).ToArray();
}
