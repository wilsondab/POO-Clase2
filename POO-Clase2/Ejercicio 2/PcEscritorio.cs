﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_2
{
    public class PcEscritorio : Maquina
    {
        public Boolean Refactorizada { get; set; }

        public PcEscritorio(string Marca, Boolean Refactorizada)
        {
            this.Refactorizada = Refactorizada;
            base.Marca = Marca;
        }
    }
}
