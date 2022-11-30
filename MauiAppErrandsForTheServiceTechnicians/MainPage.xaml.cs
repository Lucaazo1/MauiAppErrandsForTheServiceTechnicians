using MauiAppErrandsForTheServiceTechnicians.MVVM.ViewModels;

namespace MauiAppErrandsForTheServiceTechnicians;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

