using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Contrato : IImprimivel
    {
         public void imprimir()
        {
            Console.WriteLine("Contrato enviado para impressora.");
        }
    }
}