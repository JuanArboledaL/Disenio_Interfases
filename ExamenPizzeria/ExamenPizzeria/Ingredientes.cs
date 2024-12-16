using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPizzeria
{
    internal class Ingredientes
    {
        private String _ingrediente;
        private int _precio;

        public Ingredientes(String ingrediente, int precio) { 
        
            this._ingrediente = ingrediente;
            this._precio = precio;

        }

        public String getIngrediente() { 
        
            return _ingrediente;
        }

        public int getPrecio() { 
        
            return _precio;
        }
    }
}
