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
        public TipoDeRegistro()
        {
            InitializeComponent();
        }
        private void CambioEnElTipoDeRegistro(object sender, EventArgs e)
        {
            if (RbtTipoRegistroComensal.IsChecked)
            {
                LblTextoInformativoContraseña.Text = "Ingrese la contraseña para comensal";
            }
            if (RbtTipoRegistroAdministrativo.IsChecked)
            {
                LblTextoInformativoContraseña.Text = "Ingrese la contraseña para administrativo";
            }
        }
    }
}