using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public abstract class Entrega
    {
        public double distancia{get; set;}

        public abstract double CalcularFrete();
    }
}