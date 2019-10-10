using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //Se crea subclase hombre de la clase persona.
    class Hombre:Persona
    {
        //Se encapsulan los atributos
        public string Enfermedad { get; set; }
        public string Estado { get; set; }

    }
}
