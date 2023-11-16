using System;

namespace Laboratorio_No._9_Erwin_Navas
{
    public class Moto
    {
        //Modelo
        private int modelo = 2019;
    
        //Precio
        private double precio = 1000;

        //Marca
        private string marca = "";

        //iva
        private double iva = 0.12;

        //Datos
        public string MostrarDatos()
        {
            return $"Modelo: {modelo}, Precio: {precio}, Marca: {marca}, IVA: {iva}";
        }

        public void Precio(double nuevoprecio)
        {
            precio = nuevoprecio;
        }

        public void Iva (double nuevoiva)
        {
            if (nuevoiva>=0.01)
            {
                if(nuevoiva<=0.99)
                {
                    iva = nuevoiva;
                }
                else
                {
                    Console.WriteLine("El valor del iva esta entre 0.01 y 0.99");
                }
            }
        }
    }
}
