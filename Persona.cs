using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //La clase persona sera la clase padre la cual les heredara los atributos que todos tendran en 
    //Común.
    class Persona
    {
        //Se encapsulan los atributos
        public string Nombre { get; set; }
        public  string Correo { get; set; }
        public string Fecha_Nacimiento { get; set; }

    }
}
