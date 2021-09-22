using AppComedorCEET.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppComedorCEET
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TipoDeRegistro();
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
