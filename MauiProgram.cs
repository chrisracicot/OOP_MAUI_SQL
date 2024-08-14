using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.WebView.Maui;



// Final Project: Interactive Resume Application built with MAUI Blazor Hybrid 
// For Mehdi Shokrani, CPRG 211
// By: Christin Racicot, 000932597



namespace OOP211
{
    public static class MauiProgram
    {
        // This method creates and configures the MauiApp instance and initializes the Maui builder.
        public static MauiApp CreateMauiApp()
        {

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
