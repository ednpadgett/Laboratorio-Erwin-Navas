using System;

namespace Ejercicio_No._10__S6_Erwin_Navas_1067422
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba la variable A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba una variable B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba una variable c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("el resultadode a*b+C es:" + (a * b + c));
            Console.ReadLine(); 
            
            Console.WriteLine("el resultadode a*(b+C) es:" + (a * (b + c)));
            Console.ReadLine();

            Console.WriteLine("el resultadode a/(b+c)" + (a/(b*c)));
            Console.ReadLine();

            Console.WriteLine("el resultadode (3a + 2b)/c^2 es:" + ((3*a)+(2*b)/(c*c)));
            Console.ReadLine();

            if (a==0)
            {
                Console.WriteLine("Math Error");
            }
            else
            {
                if ((b*b)-(2*a*c)>=0)
                {
                    Console.WriteLine("La expreción cuadratica es:" + ((b * b) - (2 * a * c)));
                }
                else
                {
                    Console.WriteLine("Solución imaginaria");
                }
            }
        }
    }
}
