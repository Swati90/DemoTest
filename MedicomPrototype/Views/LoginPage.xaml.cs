using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MedicomPrototype.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
		{
			//Currently only redirecting the user to the landing page
			//TODO: Handle login
			var mainPage = new NavigationPage(new LandingPage());
            App.Current.MainPage = mainPage;
		}
    }
}
