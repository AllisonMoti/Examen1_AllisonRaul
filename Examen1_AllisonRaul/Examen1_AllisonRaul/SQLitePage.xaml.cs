using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1_AllisonRaul
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLitePage : ContentPage
    {
        public SQLitePage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        { 
            base.OnAppearing();
            try
        {
        ubicaciones_guardadas.ItemsSource = await App.insBaseDatos.GetUbicaciones_guardadas();
    } 
    catch (Exception ex)
        {

        Console.WriteLine(ex.ToString());
        }
}

        private async void list_locations_ItemTapped(object sender, ItemTappedEventArgs e)
        {
    locations item = (locations)e.Item;
    await DisplayAlert("Tapped", item, latitud + "was selected", "ok");
    ((ListView)sender).SelectedItem = null;

            NUEVA_UBICACION paga = new NUEVA_UBICACION();
            paga.BindingContext = item;
            await Navigation.PushAsync(paga);

        }
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
