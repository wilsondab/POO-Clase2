using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Rectangulo : FiguraGeometrica
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }

        public Rectangulo (Double lado1, Double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override double Area()
        {
            return lado1 * lado2;
        }
        public override double Perimetro()
        {
            return (lado1 * lado2) * 2;
        }
    }
}
