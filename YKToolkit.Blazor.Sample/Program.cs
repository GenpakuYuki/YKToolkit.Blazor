using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using YKToolkit.Blazor;
using YKToolkit.Blazor.Sample.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// ダイアログ表示に必要なサービスを追加
builder.Services.AddModal();
builder.Services.AddScoped<ModalDialogBase, ModalDialog>();

// ViewModel の追加
builder.Services.AddScoped<MainViewModel>();
builder.Services.AddScoped<StandardComponentsViewModel>();
builder.Services.AddScoped<AdvancedComponentsViewModel>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
