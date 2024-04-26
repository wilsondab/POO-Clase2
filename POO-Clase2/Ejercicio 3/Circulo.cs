using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Circulo : FiguraGeometrica
    {
        public double radio { get; set; }

        public Circulo(Double radio)
        {
            this.radio = radio;
        }
        
        public override double Area()
        {
            return radio * radio * Math.PI;
        }
        public override double Perimetro()
        {
            return radio * 2 * Math.PI;
        }
    }
}
