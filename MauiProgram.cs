using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using CommunityToolkit.Maui;


namespace UltimaVez;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddScoped<MainViewModel>();

        return builder.Build();
    }
}



