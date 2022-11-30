using MauiAppErrandsForTheServiceTechnicians.MVVM.ViewModels;
using MauiAppErrandsForTheServiceTechnicians.MVVM.Views;
using Microsoft.Extensions.Logging;

namespace MauiAppErrandsForTheServiceTechnicians;

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

        //Start pages and models:
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<MainPage>();

        //Services

        //Views Registration

        //View Models
        builder.Services.AddTransient<DetailViewModel>();

        //Views
        builder.Services.AddTransient<DetailPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
