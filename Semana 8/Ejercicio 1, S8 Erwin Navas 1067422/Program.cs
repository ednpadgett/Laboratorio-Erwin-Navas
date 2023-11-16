using System;

namespace Ejercicio_1__S8_Erwin_Navas_1067422
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto de la compra: ");
            string input = Console.ReadLine();
            double monto;
            if (!double.TryParse(input, out monto))
            {
                Console.WriteLine("Error: Debe ingresar un número válido.");
                return;
            }

            

            double descuento = 0;
            if (monto < 400)
            {
                descuento = 0;
                
            }
            else if (monto <= 1000)
            {
                descuento = 0.07;
            }
            else if (monto <= 5000)
            {
                descuento = 0.10;
            }
            else if (monto <= 15000)
            {
                descuento = 0.15;
            }
            else
            {
                descuento = 0.25;
            }

            double montoFinal = monto - (monto * descuento);
            Console.WriteLine("El monto final a pagar es: " + montoFinal);
        }
    }
}
    