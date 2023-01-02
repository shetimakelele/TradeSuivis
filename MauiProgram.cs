using TradeSuivis.Services;
using TradeSuivis.ViewModels;
using TradeSuivis.Views;

namespace TradeSuivis;

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

        // Services
        builder.Services.AddSingleton<ICompanyService, CompanyService>();
        //Views Registration
        builder.Services.AddSingleton<CompanyListPage>();
        builder.Services.AddSingleton<AddUpdateCompany>();

        //View Models
        builder.Services.AddSingleton<CompanyListPageViewModel>();
        builder.Services.AddSingleton<AddUpdateCompanyViewModel>();
        return builder.Build();
	}
}
