namespace CNarvaezExamen.Views;
using System;
using Microsoft.Maui.Controls;

    public partial class Login : ContentPage
    {
        
        string[,] credenciales = {
            { "estudiante2024", "uisrael2024" },
            { "examen1", "parcial1" },
            { "NombreEstudiante", "2024" }
        };

        public Login()
        {
            InitializeComponent();
        }

        
        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContrasena.Text;

            bool usuarioValido = false;

            
            for (int i = 0; i < credenciales.GetLength(0); i++)
            {
                if (usuarioIngresado == credenciales[i, 0] && contraseñaIngresada == credenciales[i, 1])
                {
                    usuarioValido = true;

                    
                    await DisplayAlert("Bienvenido", $"Usuario conectado: {credenciales[i, 0]}", "OK");

                    
                    await Navigation.PushAsync(new Views.Registro(credenciales[i, 0]));
                    break;
                }
            }

            
            if (!usuarioValido)
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
            }
        }

      
        private async void btnAcercaDe_Clicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Acerca de", "Creado por Chris Narvaez", "OK");
        }
    }





