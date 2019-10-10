using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //Se deja como subclase de la clase persona.
    class Medico:Persona
    {
        //Se encapsula
        public int Id { get; set; }
        public string Especialidad { get; set; }
    }
}
