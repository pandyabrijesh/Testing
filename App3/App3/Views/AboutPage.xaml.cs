using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            //Crashes.TrackError(new Exception("Custom Exception Added"));

            //try
            //{
            //    throw new Exception("My custom exception throw from here");
            //}
            //catch (Exception ex)
            //{

            //    Crashes.TrackError(ex);
            //}
        }
    }
}