using ActividadApi.Modelo;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActividadApi
{
    public partial class MainPage : ContentPage
    {
        private string url = "https://jsonplaceholder.typicode.com/todos";

        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            HttpClient cliente = new HttpClient();
            HttpResponseMessage response = await cliente.GetAsync(url);
            string resultado = await response.Content.ReadAsStringAsync();

            var lista = new List<UsuarioApi>();

            lista = JsonConvert.DeserializeObject<List<UsuarioApi>>(resultado);

            listaTodos.ItemsSource = lista;
        }

    }
}
