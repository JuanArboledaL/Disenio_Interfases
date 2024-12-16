using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPizzeria
{
    internal class Postres
    {
        private String _nombre;
        private int _precio;

        public Postres(String nombre, int precio)
        {

            this._nombre = nombre;
            this._precio = precio;

        }

        public String getIngrediente()
        {

            return _nombre;
        }

        public int getPrecio()
        {

            return _precio;
        }
    }
}
