﻿using Microsoft.AppCenter.Analytics;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            //Analytics.TrackEvent("Evnet for MainPage");
        }
	}
}