using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto1_ds6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaEmpPage : ContentPage
    {
        public ListaEmpPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadItems();
        }

        private async void LoadItems()
        {
            var items = await App.Context.GetItemsAsync();
            lista_empleados.ItemsSource = items;
        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevoEmpPage());
        }

    }
}