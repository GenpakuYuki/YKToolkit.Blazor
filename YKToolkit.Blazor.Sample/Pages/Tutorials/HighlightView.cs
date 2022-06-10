using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace YKToolkit.Blazor.Sample.Pages;

public class HighlightView : ComponentBase
{
    private IJSRuntime? _jsRuntime;
    [Inject]
    public IJSRuntime JsRuntime
    {
        get => this._jsRuntime ?? throw new ArgumentNullException(nameof(this._jsRuntime));
        set => this._jsRuntime = value;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JsRuntime.InvokeVoidAsync("highlightSnippet");
    }
}

public class HighlightView<T> : ViewComponentBase<T>
    where T : class
{
    private IJSRuntime? _jsRuntime;
    [Inject]
    public IJSRuntime JsRuntime
    {
        get => this._jsRuntime ?? throw new ArgumentNullException(nameof(this._jsRuntime));
        set => this._jsRuntime = value;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JsRuntime.InvokeVoidAsync("highlightSnippet");
    }
}
