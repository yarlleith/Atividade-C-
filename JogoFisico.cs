

namespace Exercicios
{
    public class JogoFisico : Jogo
    {
        public double peso;

        public JogoFisico(string nome, string plataforma, double peso)
        {
            this.nome = nome;
            this.plataforma = plataforma;
            this.peso = peso;
        }

        public override void exibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome} | Plataforma: {plataforma} | Peso: {peso}g");
        }
    }
}