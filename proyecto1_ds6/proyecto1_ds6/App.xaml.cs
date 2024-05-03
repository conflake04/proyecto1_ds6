using proyecto1_ds6.Data;
using proyecto1_ds6.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto1_ds6
{
    public partial class App : Application
    {
        public static DataBaseContext Context { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDatabase();
            MainPage = new NavigationPage(new LoginPage());
        }

        private void InitializeDatabase()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = System.IO.Path.Combine(folderApp, "Empleados.db3");
            Context = new DataBaseContext(dbPath);
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
