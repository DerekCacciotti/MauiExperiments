using System.Reflection;
using Microsoft.Extensions.Logging;
using MauiRider.Data;
using MauiRider.Shared.Interfaces;
using MauiRider.Shared.Services;
using Microsoft.Extensions.Configuration;

namespace MauiRider;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });
        
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddHttpClient("Data", c => c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/"));
        builder.Services.AddScoped<ITodoLoader, TodoLoader>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }
}