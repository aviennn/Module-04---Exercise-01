using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCell : ContentPage
    {
        public EntryCell()
        {
            InitializeComponent();
        }
        void OnSubmitEntry (object sender, EventArgs e)
        {
            string entry1Text = fcharac.Text;
            string entry2Text = hvillain.Text;
            string entry3Text = myRating.Text;
            DisplayAlert("Entered values",
                $"Favorite Character: {entry1Text}\nVillain I most Hate: {entry2Text}\nRating: {entry3Text}\n\nAre you sure you want to submit",
                "Ok", "Cancel");
        }
    }
}