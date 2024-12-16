using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioPersona
{
    internal class DatosPersonales
    {

        private String _nombre;
        private String _apellido;
        private String _direccion;
        private String _numero;
        private int _numHijos;
        private String _nombreHijo;
        private static List <String> _hijos = new List<string>();

        public DatosPersonales() { 
        

        }

        public DatosPersonales(String nombre, String apellido, String direccion, String numero, int numHijos) { 
        
            this._nombre = nombre;
            this._apellido = apellido;
            this._direccion = direccion;
            this._numero = numero;
            this._numHijos = numHijos;

        }

        public String getNombreHijo() { 
        
            return _nombreHijo;
        }

        public void anadirHijo(String hijo) { 
        
            _hijos.Add (hijo);
        }
        public void anadirHijos(List<String> hijos) {


            for (int i = 0; i < hijos.Count; i++) {

                _hijos.Add(hijos [i]);
            }

          
        }

        public List <String> getHijos() {

            return _hijos;
        }

        public String getNombre() { 
        
            return _nombre;
        }

        public string getApellido() { 
        
            return _apellido;
        }

        public string getDireccion()
        {

            return _direccion;
        }

        public String getNumero()
        {

            return _numero;
        }

        public int getNumHijos()
        {

            return _numHijos;
        }
    }
}
