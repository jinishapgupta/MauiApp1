﻿using MauiApp1.Services;
using Microsoft.Extensions.Logging;
using MauiApp1.ViewModels;
using MauiApp1.Views;


namespace MauiApp1
{
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

            
            builder.Services.AddSingleton<IProductService, ProductService>();

            
            builder.Services.AddSingleton<MainPageViewModel>();

           
            builder.Services.AddSingleton<MainPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

     return builder.Build();
        }
    }
}
