using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppErrandsForTheServiceTechnicians.MVVM.ViewModels
{
    [QueryProperty("Text", "Text")]
    public partial class DetailViewModel : ObservableObject
    {
        public DetailViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        //ObservableProperty gör det mycket snyggare med en rad kod och smidigare för att kunna fungera för alla platformer.
        [ObservableProperty]
        string text;

        public string TextComment { get; private set; }

        [RelayCommand]
        void AddComment()
        {
            if (string.IsNullOrWhiteSpace(TextComment))
                return;

            Items.Add(TextComment);
            //addar en errand
            Text = string.Empty;
        }

        [RelayCommand]
        void DeleteComment(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
