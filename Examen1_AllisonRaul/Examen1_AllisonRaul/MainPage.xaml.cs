using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen1_AllisonRaul
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btncoor_Clicked(object sender, EventArgs e)
        {
            var page1 = new Page1();
            await Navigation.PushAsync(page1);
          

        }
    }
}
