using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Ejercicio1_2.Modelo;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            var resultado = new Persona
            {
                Nombre = txtnombre.Text,
                Apellidos = txtapellidos.Text,
                Edad = txtedad.Text,
                Correo = txtcorreo.Text
            };

            var enviarDatos = new Page2();
            enviarDatos.BindingContext= resultado;
            await Navigation.PushAsync(enviarDatos);

        }
    }
}
