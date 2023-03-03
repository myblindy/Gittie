using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Storage;
using Gittie.Services;
using Gittie.ViewModels;
using Maui.Plugins.PageResolver;
using Microsoft.Extensions.Logging;

namespace Gittie;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services
            .AddSingleton<AppShell>()
            .AddSingleton<NavigationService>()
            .AddSingleton<OpenPageViewModel>()
            .AddSingleton<OpenPage>()
            .AddSingleton<RepositoryPageViewModel>()
            .AddSingleton<RepositoryPage>()
            .AddSingleton<CommonViewModel>()
            .AddSingleton(FolderPicker.Default);
        builder.UsePageResolver();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
