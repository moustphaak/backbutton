using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackButtonCIick10
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BasePage : ContentPage
	{
		public BasePage ()
		{
			InitializeComponent ();
		}

        public bool OnNavigationBackButtonPressed()
        {

            DisplayAlert("ok", "ok", "ok");

            return true;

        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }

    }

    
}