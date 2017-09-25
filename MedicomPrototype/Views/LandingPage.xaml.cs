using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MedicomPrototype.Views
{
    public partial class LandingPage : TabbedPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        async void Handle_Activated(object sender, System.EventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage();
            settingsPage.BindingContext = App.ViewModel;
            await App.Current.MainPage.Navigation.PushAsync(settingsPage, true);
        }
    }
}
