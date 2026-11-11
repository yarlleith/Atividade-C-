using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Ebook : ProdutoDigital
    {
        public int quantidadePaginas{get; set;}

        public Ebook( string nome, double preco, int quantidadePaginas) : base (nome, preco) 
        {
           this.quantidadePaginas = quantidadePaginas;
        }

    }
}