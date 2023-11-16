using System;
using System.Collections.Generic;
using System.Text;

namespace LAB12__Erwin_Navas_1067422
{
    public class TrianguloRectangulo
    {
        private double CatetoA;
        private double anguloOA;

        public double ObtenerCA()
        {
            return Math.Round(CatetoA, 3);
        }
        public double ObteneraCB()
        {
            double CatetoB = CatetoA * Math.Tan(anguloOA * Math.PI / 180);
            return Math.Round(CatetoB, 3);
        }

        public double Hipotenusa()
        {
            double hipotenusa = CatetoA / Math.Cos(anguloOA * Math.PI / 180);
            return Math.Round(hipotenusa, 3);
        }

        public double AnguloOA()
        {
            return anguloOA;
        }

        public double AnguloOB()
        {
            return 90 - anguloOA;
        }

        public double Area()
        {
            double area = 0.5 * CatetoA * ObteneraCB();
            return Math.Round(area, 3);
        }

    }
}
