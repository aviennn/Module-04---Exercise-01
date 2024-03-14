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
    public partial class ImageCell : ContentPage
    {
        ObservableCollection<Sin> sins = new ObservableCollection<Sin>();
        public ObservableCollection<Sin> Sins { get { return sins; } }
        public ImageCell()
        {
            InitializeComponent();

            SinView.ItemsSource = sins;

            sins.Add(new Sin
            {
                DisplayName = "Meliodas",
                SinType = "Dragon's Sin of Wrath",
                Image = "https://static.wikia.nocookie.net/nanatsu-no-taizai/images/3/36/Meliodas_%28Cursed_by_Light%29.png/revision/latest/scale-to-width-down/150?cb=20211111174754"
            });
            sins.Add(new Sin
            {
                DisplayName = "Merlin",
                SinType = "Boar's Sin of Gluttony",
                Image = "https://static.wikia.nocookie.net/nanatsu-no-taizai/images/9/9b/Merlin_%28Cursed_by_Light%29.png/revision/latest/scale-to-width-down/150?cb=20211111174828"
            });
            sins.Add(new Sin
            {
                DisplayName = "King",
                SinType = "Grizzly's Sin of Sloth",
                Image = "https://static.wikia.nocookie.net/nanatsu-no-taizai/images/f/f6/King_%28Cursed_by_Light%29.png/revision/latest/scale-to-width-down/150?cb=20211111174858"
            });
            sins.Add(new Sin
            {
                DisplayName = "Diane",
                SinType = "Serpent's Sin of Envy",
                Image = "https://static.wikia.nocookie.net/nanatsu-no-taizai/images/5/58/Diane_%28Cursed_by_Light%29.png/revision/latest/scale-to-width-down/150?cb=20211111174935"
            });
            sins.Add(new Sin
            {
                DisplayName = "Ban",
                SinType = "Fox's Sin of Greed",
                Image = "https://static.wikia.nocookie.net/nanatsu-no-taizai/images/a/a2/Ban_%28Cursed_by_Light%29.png/revision/latest/scale-to-width-down/150?cb=20211111174951"
            });
            sins.Add(new Sin
            {
                DisplayName = "Gowther",
                SinType = "Goat's Sin of Lust",
                Image = "https://static.wikia.nocookie.net/nanatsu-no-taizai/images/4/43/Gowther_%28Cursed_by_Light%29.png/revision/latest/scale-to-width-down/150?cb=20211111175023"
            });
            sins.Add(new Sin
            {
                DisplayName = "Escanor",
                SinType = "Lion's Sin of Pride",
                Image = "https://static.wikia.nocookie.net/nanatsu-no-taizai/images/b/b0/Escanor_%28Day%29_%28Cursed_by_Light%29.png/revision/latest/scale-to-width-down/150?cb=20211111175043"
            });
        }
    }
}