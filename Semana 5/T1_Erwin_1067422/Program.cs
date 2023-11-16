using System;

namespace T1_Erwin_1067422
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");

            //Variables
            string sNombre;
            string sEdad;
            string sCarrera;
            string sCarne;

            //Nombre
            Console.WriteLine("Escribe tu nombre: ");
            sNombre = Console.ReadLine();

            //Edad
            Console.WriteLine("Que edad tienes: ");
            sEdad = Console.ReadLine();

            //Carrera
            Console.WriteLine("Que carrera estudias: ");
            sCarrera = Console.ReadLine();

            //Carne
            Console.WriteLine("Cuál es tu número de carné: ");
            sCarne = Console.ReadLine();

            //Mensaje
            Console.WriteLine("Soy " + sNombre + ", tengo "+sEdad+ " años y estudio la carrera de " + sCarrera + 
                ", mi número de carné es: " + sCarne );


            Console.ReadKey();
        }
    }
}
