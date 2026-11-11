using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Carro : Veiculo
    {
        public int quantidadePortas;
          public Carro(string marca, string modelo, int quantidadePortas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.quantidadePortas = quantidadePortas;
        }

        public override void exibirInformacoes()
        {
            Console.WriteLine($"Marca: {marca} | Modelo: {modelo} | Quantidade de Portas: {quantidadePortas}");
        }
    }
    }
