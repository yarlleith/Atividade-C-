using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public abstract class  ProdutoDigital
    {
        public string nome = "";
        public double preco;

        public ProdutoDigital(string nomeProduto, double precoProduto)
        {
            nome = nomeProduto;
            preco = precoProduto;
        
        }

    }
}