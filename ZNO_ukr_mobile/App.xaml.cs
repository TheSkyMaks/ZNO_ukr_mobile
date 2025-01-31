﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZNO_ukr_mobile.Services;
using ZNO_ukr_mobile.Views;

namespace ZNO_ukr_mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
