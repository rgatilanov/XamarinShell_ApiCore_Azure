using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinClient_ApiAzure.Services;
using XamarinClient_ApiAzure.Views;

namespace XamarinClient_ApiAzure
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            DependencyService.Register<UserData>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
