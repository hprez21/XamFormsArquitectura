using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XamFormsArquitectura.Helpers
{
    public static class HttpHelper<T>
    {
        public static async Task<T> ConsultarWSAsync(string url)
        {
            //Creamos una instancia de HttpClient
            var client = new HttpClient();

            //Asignamos la URL
            client.BaseAddress = new Uri(url);
            //Llamada asíncrona al sitio
            var response = await client.GetAsync(client.BaseAddress);
            //Nos aseguramos de recibir una respuesta satisfactoria

            response.EnsureSuccessStatusCode();
            //Convertimos la respuesta a una variable string
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            //Se deserializa la cadena y se convierte en una instancia de WeatherResult
            var result = JsonConvert.DeserializeObject<T>(jsonResult);
            return result;
        }

    }

}
