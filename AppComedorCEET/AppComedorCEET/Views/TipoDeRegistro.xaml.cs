using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppComedorCEET.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoDeRegistro : ContentPage
    {
        private string tipoSeleccionado;
        public TipoDeRegistro()
        {
            InitializeComponent();
        }
        private void CambioEnElTipoDeRegistro(object sender, EventArgs e)
        {
            if (RbtTipoRegistroComensal.IsChecked)
            {
                tipoSeleccionado = "Comensal";
            } else if (RbtTipoRegistroAdministrativo.IsChecked)
            {
                tipoSeleccionado = "Administrativo";
            }
            LblTextoInformativoContraseña.Text = $"Ingrese la contraseña para {tipoSeleccionado}";
        }
        private void AbrirPantallaCrearCuenta(object sender, EventArgs e)
        {
                _ = Navigation.PushAsync(new CrearCuenta(tipoSeleccionado));
        }
    }
}