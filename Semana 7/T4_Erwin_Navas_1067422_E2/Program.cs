using System;

namespace T4_Erwin_Navas_1067422_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erwin Navas - 1067422");
            Console.WriteLine("Ingrese la cantidad de quetzales(Limite 999.99): ");
            double q = Convert.ToDouble(Console.ReadLine());

            //Condiciones

            if(q>=0)
            {
                if (q<=999.99) 
                {
                   if (q>=100)
                   {
                        
                   }
                   else
                   {

                   }

                }
                else
                {
                    Console.WriteLine("Datos no validos");
                }
                
            }
            
            else
            {
                Console.WriteLine("Datos no validos");
            }

            Console.ReadKey();
 
        }
    }
}
