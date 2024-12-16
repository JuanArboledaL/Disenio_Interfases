using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formAutoGrid
{
    internal class Extras
    {
        private String _nombreComponente;
        private int _precio;

        public Extras(string nombreComponente, int precio)
        {
            _nombreComponente = nombreComponente;
            _precio = precio;

        }

        public string getNombreComponente() { 
        
            return _nombreComponente ;
        }

        public int getPrecio() { 
        
            return _precio ;
        }

        
    }
}
