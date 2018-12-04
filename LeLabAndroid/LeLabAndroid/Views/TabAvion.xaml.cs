using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLabAndroid.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabAvion : ContentPage
	{
		public TabAvion ()
		{
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();

	        imageAvion.TranslationX = -350;
	        imageAvion.TranslationY = -150;
	        imageAvion.Rotation = 45;
	        imageAvion.Scale = 0.7;
	        imageAvion.Opacity = 0;

            Animation();
	    }

	    private async void Animation()
	    {
	        uint length = 800;

	        await imageAvion.FadeTo(1, 500);
	        await imageAvion.TranslateTo(0, 0, length, Easing.SinOut);
	        await imageAvion.RotateTo(0, length, Easing.SinOut);
	        await imageAvion.ScaleTo(1, length, Easing.SinOut);
        }
	}
}