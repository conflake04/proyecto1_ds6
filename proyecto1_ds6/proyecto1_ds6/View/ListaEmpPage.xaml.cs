using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto1_ds6.Models;
using proyecto1_ds6.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto1_ds6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaEmpPage : ContentPage
    {
        
        public object DataStore { get; private set; }

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

        private async void lista_empleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            Item selectionItem = e.SelectedItem as Item;
            await Navigation.PushAsync(new PlantillaPage(selectionItem));
        }

    }
   
}