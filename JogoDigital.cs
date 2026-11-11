

namespace Exercicios
{
    public class JogoDigital : Jogo
    {
        public double tamanhoGB;

        public JogoDigital(string nome, string plataforma, double tamanhoGB)
        {
            this.nome = nome;
            this.plataforma = plataforma;
            this.tamanhoGB = tamanhoGB;
        }

        public override void exibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome} | Plataforma: {plataforma} | Tamanho: {tamanhoGB}GB");
        }
    }
}