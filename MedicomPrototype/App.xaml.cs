using System;
using MedicomPrototype.ViewModels;
using Xamarin.Forms;

namespace MedicomPrototype
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";
        public static AppViewModel ViewModel { get; set; }

        public App()
        {
            InitializeComponent();

            ViewModel = new AppViewModel();
            ViewModel.Initialize();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new Views.LoginPage();
            else
                MainPage = new NavigationPage(new Views.LoginPage());
        }
    }
}
