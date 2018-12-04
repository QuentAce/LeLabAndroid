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
	public partial class CountPage : ContentPage
	{
	    private int _value = 0;
		public CountPage ()
		{
			InitializeComponent ();
		}

	    private void ButtonAdd(object sender, EventArgs e)
	    {
	        _value++;
	        LabelCount.Text = _value.ToString();
	    }
	}
}