using System;

namespace LAB12__Erwin_Navas_1067422
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianguloRectangulo objTriangulo = new TrianguloRectangulo();

            Console.WriteLine("Ingrese el cateto a: ");
            objTriangulo.ObtenerCA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el cateto opuesto en grados: ");
            objTriangulo.AnguloOA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor del cateto a: " + objTriangulo.ObtenerCA());
            Console.WriteLine("Valor del cateto b: " + objTriangulo.ObteneraCB());

            Console.WriteLine("Valor de hipotenusa: " + objTriangulo.Hipotenusa());

            Console.WriteLine("Valor de ángulo opuesto de A: " + objTriangulo.AnguloOA());

            Console.WriteLine("Valor de ángulo opuesto de B: " + objTriangulo.AnguloOB());

            Console.WriteLine("Valor de área: " + objTriangulo.Area());
        }
    }
}
