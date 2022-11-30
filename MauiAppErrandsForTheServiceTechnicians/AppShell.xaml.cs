using MauiAppErrandsForTheServiceTechnicians.MVVM.Views;

namespace MauiAppErrandsForTheServiceTechnicians;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
	}
}
