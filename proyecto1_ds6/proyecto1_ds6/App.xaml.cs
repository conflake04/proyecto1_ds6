using proyecto1_ds6.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto1_ds6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
