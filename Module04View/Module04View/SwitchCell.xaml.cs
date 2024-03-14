using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchCell : ContentPage
    {
        ObservableCollection<Sin> sins = new ObservableCollection<Sin>();
        public ObservableCollection<Sin> Sins { get { return sins; } }
        public SwitchCell()
        {
            InitializeComponent();

            SinView.ItemsSource = sins;

            sins.Add(new Sin
            {
                DisplayName = "Meliodas"
            });
            sins.Add(new Sin
            {
                DisplayName = "Merlin"
            });
            sins.Add(new Sin
            {
                DisplayName = "King"
            });
            sins.Add(new Sin
            {
                DisplayName = "Diane"
            });
            sins.Add(new Sin
            {
                DisplayName = "Ban"
            });
            sins.Add(new Sin
            {
                DisplayName = "Gowther"
            });
            sins.Add(new Sin
            {
                DisplayName = "Escanor" 
            });
        }
        public void displayMsg (object sender, ToggledEventArgs e)
        {
          

            bool isToggledOn = e.Value;

            if (isToggledOn)
            {
                DisplayAlert("You like the character", "The Switch is now turned on!", "OK");
            }
            else
            {
                DisplayAlert("You don't like the character", "The Switch is now turned off!", "OK");
            }
        }
    }
}