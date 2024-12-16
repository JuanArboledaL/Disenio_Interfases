using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioPersona
{
    internal class Personas 
    {

        private static List<DatosPersonales> _listaPersonas = new List<DatosPersonales>();


        public Personas() {

        }

        public List<DatosPersonales> getPersonas(){
        
            return _listaPersonas;
        }

       
    }
}
