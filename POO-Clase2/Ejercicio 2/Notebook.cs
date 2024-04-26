using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_2
{
    public class Notebook : Maquina
    {
        public int Peso { get; set; } 

        public Notebook(string Marca, int Peso)
        {
            this.Peso = 250;
            base.Marca = Marca;
        }

    }
}
