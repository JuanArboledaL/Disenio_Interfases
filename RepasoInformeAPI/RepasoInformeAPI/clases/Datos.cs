using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoInformeAPI.clases
{
    internal class Datos
    {
        public int id {  get; set; }
        public string title {  get; set; }
        public float price {  get; set; }
        public string description {  get; set; }
        public string category {  get; set; }
        public string image {  get; set; }
        public Rating rating {  get; set; }
    }

    internal class Rating { 
    
        public float Rate { get; set;}

        public int count {  get; set; }
    }
}
