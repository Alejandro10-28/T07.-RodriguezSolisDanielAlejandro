using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //Se crea subclase mujer de la clase persona.
    class Mujer:Persona
    {
        //Se encapsulan.
        public string Enfermedad { get; set; }
        public string Estado { get; set; }
    }
}
