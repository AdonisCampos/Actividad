using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ACTIVIDAD1
{
    public partial class MainPage : ContentPage
    {
        private const string URL = "https://localhost:7069/ACTIVIDAD";

        public MainPage()
        {
            InitializeComponent();
            GetDataFromServerAsync();

        }

        private async Task GetDataFromServerAsync()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(URL);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    await DisplayAlert("Respuesta del servidor", content, "Aceptar");
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo obtener la respuesta del servidor", "Aceptar");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Se produjo un error: {ex.Message}", "Aceptar");
            }
        }

    }
}