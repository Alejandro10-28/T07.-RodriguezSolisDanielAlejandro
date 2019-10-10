using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //Se crea subclase paciente de la clase persona.
    class Paciente:Persona
    {// Se encapsulan los atributos 
        public int Id { get; set; }
        public string TipoPaciente { get; set; }
    }
}
