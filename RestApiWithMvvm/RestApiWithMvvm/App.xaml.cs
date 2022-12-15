﻿using RestApiWithMvvm.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApiWithMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new QuotesPage();
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
