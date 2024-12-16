using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicarAPI.Clases
{
    internal class Api
    {
       
        public static List<Productos> Acceso()
        {
            String direccion = "https://fakestoreapi.com/";
            RestClient client = new RestClient(direccion);
            RestRequest request = new RestRequest("products");
            var response = client.Execute(request);

            List<Productos> result = JsonConvert.DeserializeObject<List<Productos>>(response.Content);

            return result;
        }
    }

}
