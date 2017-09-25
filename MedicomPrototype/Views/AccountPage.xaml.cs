using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MedicomPrototype.Views
{
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
			await Navigation.PushAsync(new AddHCPPage());
        }

        async void AddContacts_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddContactsPage());
        }

        async void SaveConditions_Clicked(object sender, System.EventArgs e)
        {
            ConditionsPage conditionsPage = new ConditionsPage();
            conditionsPage.BindingContext = App.ViewModel;
            await Navigation.PushAsync(conditionsPage);
        }
    }
}
