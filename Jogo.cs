
namespace Exercicios
{
    public abstract class Jogo
    {
        public string nome ="";
        public string plataforma{get; set;} = "";

        public virtual void exibirInformacoes(){}

    }
}