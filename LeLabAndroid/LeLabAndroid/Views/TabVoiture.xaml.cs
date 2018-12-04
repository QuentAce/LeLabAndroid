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
	public partial class TabVoiture : ContentPage
	{
		public TabVoiture ()
		{
			InitializeComponent ();
		    //imageVoiture.Opacity = 0;
        }

	    protected override void OnAppearing()
	    {
            base.OnAppearing();
	        imageVoiture.TranslationX = -350;
	        //imageVoiture.TranslationY = -150;
	        //imageVoiture.Rotation = 45;
	        imageVoiture.Scale = 0.7;
	        imageVoiture.Opacity = 0;

	        Animation();
	    }

	    private async void Animation()
	    {
	        uint length = 800;

	        await imageVoiture.FadeTo(1, 500);
	        await imageVoiture.TranslateTo(0, 0, length, Easing.SinOut);
	        await imageVoiture.RotateTo(0, length, Easing.SinOut);
	        await imageVoiture.ScaleTo(1, length, Easing.SinOut);
	    }
    }
}