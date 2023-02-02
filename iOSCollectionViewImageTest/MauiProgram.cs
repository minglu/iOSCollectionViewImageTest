using CommunityToolkit.Maui;
using iOSCollectionViewImageTest.ViewModel;
using Microsoft.Extensions.Logging;

namespace iOSCollectionViewImageTest;

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

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<ImagesInCollectionViewPage>();
        builder.Services.AddTransient<ImagesViewModel>();

        return builder.Build();
    }
}

