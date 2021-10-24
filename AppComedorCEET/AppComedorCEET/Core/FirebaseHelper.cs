using AppComedorCEET.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppComedorCEET.Core
{
    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://comedoreet277-default-rtdb.firebaseio.com/");
        public async Task AddComensal(string nombre)
        {

            await firebase
              .Child("Comensales")
              .PostAsync(new Comensal() {  Id = Guid.NewGuid(), Nombre = nombre });
        }
    }
}
