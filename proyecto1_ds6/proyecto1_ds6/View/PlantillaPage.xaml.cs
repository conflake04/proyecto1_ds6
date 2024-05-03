using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto1_ds6.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto1_ds6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantillaPage : ContentPage
    {
        Item item;
        public PlantillaPage(Item item)
        {
            InitializeComponent();
            this.item = item;

            nombre_e.Text = item.nombre;
            cedula_e.Text = item.cedula;
            salario_e.Text = item.salario.ToString();
            seg_social.Text = item.seg_social;
            seg_educ.Text = item.seg_educ;
            


        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            
            if (double.TryParse(salario_e.Text, out double salario))
            {
                
                double deduccionSegSocial = salario * 0.0975;
                double deduccionSegEducativo = salario * 0.0125;

                
                double salarioNeto = salario - (deduccionSegSocial + deduccionSegEducativo);

                
                seg_social.Text = deduccionSegSocial.ToString();
                seg_educ.Text = deduccionSegEducativo.ToString();
                salario_neto.Text = salarioNeto.ToString();
            }
            else
            {
                DisplayAlert("Error", "Por favor ingrese un valor válido para el salario.", "OK");
            }
        }


        private void btn3_Clicked(object sender, EventArgs e)
        {

        }
    }
}