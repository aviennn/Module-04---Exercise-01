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
    public partial class TextCell : ContentPage
    {
        ObservableCollection <Sin> sins = new ObservableCollection <Sin>();
        public ObservableCollection <Sin> Sins { get { return sins; } }
        public TextCell()
        {
            InitializeComponent();
           

            SinView.ItemsSource = sins;

            sins.Add(new Sin
            {
                DisplayName = "Meliodas",
                SinType = "Dragon's Sin of Wrath",
            });
            sins.Add(new Sin
            {
                DisplayName = "Merlin",
                SinType = "Boar's Sin of Gluttony",
            });
            sins.Add(new Sin
            {
                DisplayName = "King",
                SinType = "Grizzly's Sin of Sloth",
            });
            sins.Add(new Sin
            {
                DisplayName = "Diane",
                SinType = "Serpent's Sin of Envy",
            });
            sins.Add(new Sin
            {
                DisplayName = "Ban",
                SinType = "Fox's Sin of Greed",
            });
            sins.Add(new Sin
            {
                DisplayName = "Gowther",
                SinType = "Goat's Sin of Lust",
            });
            sins.Add(new Sin
            {
                DisplayName = "Escanor",
                SinType = "Lion's Sin of Pride",
            });

        }
        private void MenuAbout (object sender, EventArgs e)
        {
            DisplayAlert("About", "Seven Deadly Sins is an action-packed anime following the adventures of a group of powerful knights as they " +
                "strive to save their kingdom from corruption and tyranny while confronting their own past sins.", "Got it!");
        }
    }
}