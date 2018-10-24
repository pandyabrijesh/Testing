using System;
using Xamarin.Forms;
using App3.Views;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            AppCenter.Start("android=de525739-817f-494b-8b99-eeaa7bfa33ee;ios=f9f59949-06c5-4684-9eff-c98391d9c255", typeof(Analytics), typeof(Crashes));

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
