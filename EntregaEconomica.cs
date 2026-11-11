using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class EntregaEconomica : Entrega
    {
           public EntregaEconomica(double distancia)
        {
            this.distancia = distancia;
        }
        public override double CalcularFrete()
        {
            return distancia * 4;
        }
    }
    }
