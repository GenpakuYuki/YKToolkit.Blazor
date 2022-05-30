using Microsoft.Extensions.DependencyInjection;

namespace YKToolkit.Blazor;

/// <summary>
/// ModalService クラスに関する拡張機能を提供します。
/// </summary>
public static class ModalServiceExtensions
{
    /// <summary>
    /// モーダルダイアログ機能を追加します。
    /// </summary>
    /// <param name="services">機能を提供するサービス</param>
    /// <returns>機能が追加されたサービスを返します。</returns>
    public static IServiceCollection AddModal(this IServiceCollection services)
    {
        return services.AddScoped<IModalService, ModalService>();
    }
}