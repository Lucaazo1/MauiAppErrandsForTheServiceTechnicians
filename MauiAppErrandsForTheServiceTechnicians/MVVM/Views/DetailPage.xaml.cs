using MauiAppErrandsForTheServiceTechnicians.MVVM.ViewModels;

namespace MauiAppErrandsForTheServiceTechnicians.MVVM.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel dvm)
	{
		InitializeComponent();
		BindingContext = dvm;
	}
}