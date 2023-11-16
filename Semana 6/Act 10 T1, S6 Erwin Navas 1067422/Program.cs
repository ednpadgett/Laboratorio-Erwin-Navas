using System;

namespace Act_10_T1__S6_Erwin_Navas_1067422
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de opción del resultado que busca");  
            Console.WriteLine("1. velocidad final");
            Console.WriteLine("2. velocidad inicial");
            Console.WriteLine("3. aceleración");
            Console.WriteLine("4. Tiempo");
            int mru = Convert.ToInt32(Console.ReadLine());
        
            switch (mru)
            {
                case 1:
                    Console.WriteLine("Ingrese la velocidad inicial: ");
                    int vo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese la aceleración: ");
                    int ac = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el tiempo: ");
                    int t = Convert.ToInt32(Console.ReadLine());

                    int vf = (vo + (ac * t));
                    Console.WriteLine("La velocidad final es de: "+ vf);
                    break;

                case 2: 
                    Console.WriteLine("ingrese la velocidad final");
                    int vf2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el aceleración: ");
                    int ac2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el tiempo: ");
                    int t2 = Convert.ToInt32(Console.ReadLine());

                    int vo2 = (vf2 - (ac2*t2));
                    Console.WriteLine("La velocidad inicial es de:" + vo2);

                    break;

                 case 3:
                    Console.WriteLine("Ingrese la velocidad final: ");
                    int vf3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese la velocidad inicial: ");
                    int vo3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el tiempo: ");
                    int t3 = Convert.ToInt32(Console.ReadLine());

                    int a3 = (vf3 - vo3) / t3;
                    Console.WriteLine("La aceleración es de:" + a3);

                    break;

                case 4:
                    Console.WriteLine("Ingrese la velocidad final: ");
                    int vf4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese la velocidad inicial: ");
                    int vo4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese la aceleración: ");
                    int a4 = Convert.ToInt32(Console.ReadLine());

                    int t4 = (vf4 - vo4) / a4;
                    Console.WriteLine("La tiempo es de:" + t4);

                    break;

                default:
                    Console.WriteLine("Espere un momento");
                    break;
            }
            Console.ReadKey();
        }
    }
}
