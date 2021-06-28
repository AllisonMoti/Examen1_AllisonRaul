using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Examen1_AllisonRaul
{
    public partial class App : Application
    {

        static BaseDatos BaseDatos;
           public static BaseDatos insBaseDatos


        {
            get
            {
                if (BaseDatos == null)
                {
                    BaseDatos = new BaseDatos(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DB.db3"));
                }
                return BaseDatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
