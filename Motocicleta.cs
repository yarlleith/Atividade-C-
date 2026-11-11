using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Motocicleta : Veiculo
    {
        public double cilidradas;
        public Motocicleta(string marca, string modelo, double cilidradas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilidradas = cilidradas;
        }

        public override void exibirInformacoes()
        {
            Console.WriteLine($"Marca: {marca} | Modelo: {modelo} | Cilindradas: {cilidradas}");
        }

        
    }
}