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
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

	    private void CounterButtonCLicked(object sender, EventArgs e)
	    {
	        this.Navigation.PushAsync(new CountPage());
	    }

	    private void TabsButtonCLicked(object sender, EventArgs e)
	    {
	        this.Navigation.PushAsync(new TabsPage());
	    }
	}
}