using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //Se hace una subclase de la clase persona.
    class Fisioterapeuta:Persona
    {
        //Se encapsulan los atributos
        public double  ID {get; set; }
        public string  Consultorio { get; set; }
        public  string Area { get; set; }
    }
}
