using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void TextCell_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextCell());
        }
        private async void ImageCell_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageCell());
        }
        private async void SwitchCell_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchCell());
        }
        private async void EntryCell_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryCell());
        }
        private async void CollectionView_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync (new CollectionView());
        }
        private async void DisplayAlert_Clicked (object sender, EventArgs e)
        {
            await DisplayAlert("Details", "This is the main dashboard that has pages for different kinds of ListView", "I UNDERSTSAND");
        }

    }
}
