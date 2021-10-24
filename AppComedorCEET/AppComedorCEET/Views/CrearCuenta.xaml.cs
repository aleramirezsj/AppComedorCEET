using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppComedorCEET.Core;
using AppComedorCEET.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppComedorCEET.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearCuenta : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public string TipoSeleccionado { get; }
        public CrearCuenta()
        {
            InitializeComponent();
            TipoSeleccionado = "Comensal";
            AjustarTituloYBotón();
        }

        public CrearCuenta(string tipoSeleccionado)
        {
            InitializeComponent();
            TipoSeleccionado = tipoSeleccionado;
            AjustarTituloYBotón();
        }

        private void AjustarTituloYBotón()
        {
            LblTituloPantalla.Text = LblTituloPantalla.Text + TipoSeleccionado;
            BtnCrearCuenta.Text = BtnCrearCuenta.Text + TipoSeleccionado;
        }
        private async void CrearCuentaEnFirebase(object sender, EventArgs e)
        {

            await firebaseHelper.AddComensal("Juan Perez");

        }
    }
}