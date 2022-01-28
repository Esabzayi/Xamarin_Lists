using Android.Content.Res;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Lists
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainTabbedPage());
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
