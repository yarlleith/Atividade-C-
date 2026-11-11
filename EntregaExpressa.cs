using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Exercicios
{
    public class EntregaExpressa : Entrega
    {
        public EntregaExpressa(double distancia)
        {
            this.distancia = distancia;
        }
        public override double CalcularFrete()
        {
            
            return (distancia * 8) + 2;
        }
    }
}

