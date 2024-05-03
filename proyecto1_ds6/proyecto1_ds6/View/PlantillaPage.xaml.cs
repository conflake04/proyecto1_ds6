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
            DetallesE.ItemsSourc = item;
        }

    }
}