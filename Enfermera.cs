using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //Se crean las subclases las cuales tendras sus atributos unicos dependientes de las que todos 
    //tienen en común
    class Enfermera:Persona
    {
        //Se encapsulan los atributos.
        public int Id { get; set; }
        public string Area { get; set; }
    }
}
