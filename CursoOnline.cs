using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class CursoOnline : ProdutoDigital
    {
        public double cargaHoraria;

        public CursoOnline( string nome, double preco, double cargaHoraria) : base (nome, preco) 
        {
           this.cargaHoraria = cargaHoraria;
        }

    }
}
