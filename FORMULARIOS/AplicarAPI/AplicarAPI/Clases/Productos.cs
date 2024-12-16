using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicarAPI.Clases
{

    internal class Productos
    {
        public int Id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public Rating rating { get; set; }

    }


}

