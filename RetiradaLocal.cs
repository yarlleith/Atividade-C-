using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class RetiradaLocal : Entrega
    {

        public RetiradaLocal(double distancia)
        {
            this.distancia = distancia;
        }
        public override double CalcularFrete()
        {
            return distancia * 0;
        }
    }
}