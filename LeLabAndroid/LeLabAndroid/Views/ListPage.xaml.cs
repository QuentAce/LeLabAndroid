using System;
using System.Collections.Generic;
using System.Linq;
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
                new Articles {Nom = "Lait", Prix = "4€"},
                new Articles {Nom = "Pain", Prix = "1€"},
                new Articles {Nom = "Beurre", Prix = "2.5€"},
                new Articles {Nom = "Sucre", Prix = "3€"}
            };

            MaListeView.ItemsSource = articles;
        }
    }

    ///// <summary>
    ///// 
    ///// </summary>
    //public class Article
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public string Nom { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public string Prix { get; set; }
    //}
}