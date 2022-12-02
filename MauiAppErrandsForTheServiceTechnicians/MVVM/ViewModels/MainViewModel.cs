using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppErrandsForTheServiceTechnicians.MVVM.Views;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppErrandsForTheServiceTechnicians.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        //ObservableProperty gör det mycket snyggare med en rad kod och smidigare för att kunna fungera för alla platformer.
        [ObservableProperty]
        string text;


        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(Text);
            //addar en errand
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if(Items.Contains(s))
            {
                Items.Remove(s);
            }
        }


        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }




        //Gammal kod observebleobject är ny med allt det här:
        //public string Text
        //{
        //    get => text;
        //    set
        //    {
        //        text = value;
        //        OnPropertyChanged(nameof(Text));
        //    }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;

        //void OnPropertyChanged(string name) =>
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
