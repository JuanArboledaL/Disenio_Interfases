using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPizzeria
{
    internal class Bebidas
    {

        private String _nombre;
        private int _precio;

        public Bebidas() { 
        
        }
        public Bebidas(String nombre, int precio)
        {

            this._nombre = nombre;
            this._precio = precio;

        }

        public String getNombre( List<Bebidas> bebida)
        {

            return _nombre;
        }

        public int getPrecio()
        {

            return _precio;
        }
    }
}
