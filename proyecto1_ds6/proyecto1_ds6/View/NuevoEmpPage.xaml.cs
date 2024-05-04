using proyecto1_ds6.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto1_ds6.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NuevoEmpPage : ContentPage
	{
		public NuevoEmpPage ()
		{
			InitializeComponent ();
		}

        private async void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            try 
			{
				var item = new Item
				{
					nombre = nombreEntry.Text,
					cedula = cedulaEntry.Text,
					seg_social = "9.75%",
					seg_educ = "1.25%",
					salario = Convert.ToDouble(salarioEntry.Text),
					decTerMes = 0
				};
				var result = await App.Context.InsertItemAsyn(item);
                if (result == 1)
                {
					await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo guardar el empleado", "Aceptar");
                }
            } 
			
            
            catch (Exception)
            {
                string men = "Error en el campo SALARIO. El dato a introducir debe ser numerico";
                await DisplayAlert("Error", men, "Aceptar");
            }
        }
    }
}