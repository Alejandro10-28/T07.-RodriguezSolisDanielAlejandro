using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase principal donde tengo la bienvenida al programa
            Principal k = new Principal();
            k.Bienvenida();
            Console.ReadKey();
            //Se crean los objetos para cada clase donde se le asignaran los datos
            Paciente Paciente1 = new Paciente();
            Paciente1.Correo = "Drodriguez.epflc2@gmail.com";
            Paciente1.Fecha_Nacimiento = "28/10/99";
            Paciente1.Id = 215;
            Paciente1.Nombre = "Daniel Alejandro Rodriguez Solis";
            Paciente1.TipoPaciente = "Grave";
            Console.WriteLine("======Paciente======");
            //Se imprimen los datos correspondientes
            Console.WriteLine("Nombre:" + Paciente1.Nombre);
            Console.WriteLine("Fecha de nacimiento:" + Paciente1.Fecha_Nacimiento);
            Console.WriteLine("Id:" + Paciente1.Id);
            Console.WriteLine("Tipo de paciente:" + Paciente1.TipoPaciente);
            Console.WriteLine("Correo:" + Paciente1.Correo);

            Console.WriteLine("========================================");

            Medico Medico1 = new Medico();

            Medico1.Nombre = "Ramon Garte";
            Medico1.Id = 21;
            Medico1.Fecha_Nacimiento = "23/9/80";
            Medico1.Especialidad = "NeuroCirujano";

            Medico1.Correo = "JACKAR@Hotmail.com";
            Console.WriteLine("======Medico======");

            Console.WriteLine("Nombre:" + Medico1.Nombre);
            Console.WriteLine("Id:" + Medico1.Id);
            Console.WriteLine("Fecha de nacimiento:" + Medico1.Fecha_Nacimiento);
            Console.WriteLine("Especialidad:" + Medico1.Especialidad);
            Console.WriteLine("Correo:" + Medico1.Correo);

            Console.WriteLine("========================================");


            Fisioterapeuta Fisioterapeuta1 = new Fisioterapeuta();
            Fisioterapeuta1.Area = "Piso 10";
            Fisioterapeuta1.Consultorio = "20-05";
            Fisioterapeuta1.Correo = "MSJ@GMAIL.COM";
            Fisioterapeuta1.ID = 148;
            Fisioterapeuta1.Nombre = "Bill skargas";
            Console.WriteLine("======Fisioterapeuta======");

            Console.WriteLine("Nombre:" + Fisioterapeuta1.Nombre);
            Console.WriteLine("Id:" + Fisioterapeuta1.ID);
            Console.WriteLine("Fecha de nacimiento:" + Fisioterapeuta1.Fecha_Nacimiento);
            Console.WriteLine("Consultorio:" + Fisioterapeuta1.Consultorio);
            Console.WriteLine("Area:" +Fisioterapeuta1.Area);

            Console.WriteLine("========================================");


            Hombre Hombre1 = new Hombre();
            Hombre1.Nombre = "Alejandro";
            Hombre1.Estado = "Medio muerto";
            Hombre1.Enfermedad = "Ser guapo";
            Hombre1.Correo = "ILOVEYOU@GMAIL.COM";
            Hombre1.Fecha_Nacimiento = "28/5/2001";
            Console.WriteLine("======Hombre======");

            Console.WriteLine("Nombre:" + Hombre1.Nombre);
            Console.WriteLine("Estado:" + Hombre1.Estado);
            Console.WriteLine("Enfermedad:" + Hombre1.Enfermedad);
            Console.WriteLine("Correo:" + Hombre1.Correo);
            Console.WriteLine("Fecha de nacimiento:" + Hombre1.Fecha_Nacimiento);

            Console.WriteLine("========================================");


            Cirujano Cirujano1 = new Cirujano();
            Cirujano1.Nombre = "ALDO";
            Cirujano1.Fecha_Nacimiento = "2/6/95";
            Cirujano1.Correo = "MADEO@GMAIL.COM";
            Cirujano1.Area = "Odontologia";
            Console.WriteLine("======Cirujano======");


            Console.WriteLine("Nombre:" + Cirujano1.Nombre);
            Console.WriteLine("Id:" +Cirujano1.Correo);
            Console.WriteLine("Fecha de nacimiento:" + Cirujano1.Fecha_Nacimiento);
            Console.WriteLine("Area:" + Cirujano1.Area);
            Console.WriteLine("========================================");


            Medico_Familiar Medicof1 = new Medico_Familiar();
            Medicof1.Correo = "TUDOCFAV@GMAIL.COM";
            Medicof1.Especialidad = "Lo que tu quieras";
            Medicof1.Fecha_Nacimiento = "21/3/2002";
            Medicof1.Id = 265;
            Medicof1.Nombre = "Oliver";
            Console.WriteLine("======Medico Familiar======");

            Console.WriteLine("Nombre:" + Medicof1.Nombre);
            Console.WriteLine("Id:" + Medicof1.Id);
            Console.WriteLine("Fecha de nacimiento:" + Medicof1.Fecha_Nacimiento);
            Console.WriteLine("Especialidad:" + Medicof1.Especialidad);
            Console.WriteLine("Correo:" + Medicof1.Correo);

            Console.WriteLine("========================================");


            Enfermera Enfermera1 = new Enfermera();
            Enfermera1.Nombre = "Mariana";
            Enfermera1.Id = 2134;
            Enfermera1.Area = "Piso 3";
            Enfermera1.Correo = "MWIEQ@GMAIL.COM";
            Enfermera1.Fecha_Nacimiento = "15/7/96";
            Console.WriteLine("======Enfermera======");

            Console.WriteLine("Nombre:" + Enfermera1.Nombre);
            Console.WriteLine("Id:" + Enfermera1.Id);
            Console.WriteLine("Fecha de nacimiento:" + Enfermera1.Fecha_Nacimiento);
            Console.WriteLine("Correo:" + Enfermera1.Correo);
            Console.WriteLine("Area:" + Enfermera1.Area);

            Console.WriteLine("========================================");


            Mujer Mujer1 = new Mujer();
            Mujer1.Enfermedad = "Dolor de estomago";
            Mujer1.Estado = "Cool";
            Mujer1.Nombre = "Maria";
            Mujer1.Fecha_Nacimiento = "1/4/15";
            Mujer1.Correo = "JDFOEF@GMAIL.COM";
            Console.WriteLine("======Mujer======");

            Console.WriteLine("Nombre:" + Mujer1.Nombre);
            Console.WriteLine("Estado:" + Mujer1.Estado);
            Console.WriteLine("Correo:" + Mujer1.Correo);
            Console.WriteLine("Fecha de nacimiento:" + Mujer1.Fecha_Nacimiento);

            Console.WriteLine("========================================");


            Console.ReadKey();
        }
    }
}
