using MelodyFusionMobile.Service;
using RestSharp;

namespace MelodyFusionMobile;

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

		builder.Services.AddHttpClient();
        builder.Services.AddHttpClient("MelodyFusion", client =>
        {
            
            client.BaseAddress = new Uri("https://localhost:7293");
           
        });
        //builder.Services.AddScoped<RestClient>();
        //builder.Services.AddScoped<HttpClient>();
        builder.Services.AddScoped<MainPage>();
        builder.Services.AddScoped<AuthService>();


        return builder.Build();
	}
}
