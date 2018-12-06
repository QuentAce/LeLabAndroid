using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using LeLabAndroid.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLabAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        List<Articles> articles;

        public ListPage()
        {
            InitializeComponent();
            articles = new List<Articles>
            {
                new Articles {Nom = "Lait", Prix = "4€", Description = "Vous avez choisit le Lait"},
                new Articles {Nom = "Pain", Prix = "1€", Description = "Vous avez choisit le Pain"},
                new Articles {Nom = "Beurre", Prix = "2.5€", Description = "Vous avez choisit le Beurre"},
                new Articles {Nom = "Sucre", Prix = "3€", Description = "Vous avez choisit le Sucre"}
            };

            MaListeView.ItemsSource = articles;

            MaListeView.ItemSelected += (sender, e) =>
            {
                if (MaListeView.SelectedItem != null)
                {
                    Articles item = MaListeView.SelectedItem as Articles;
                    DisplayAlert(item.Nom, item.Description, "OK");
                    MaListeView.SelectedItem = null;
                }
            };
        }
    }
}