using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public void Exportar()
        {
            Console.WriteLine("Relatorio sendo exportado.");
        }

        public void imprimir()
        {
            Console.WriteLine("Relatorio enviado para impressora.");
        }
    }
}