using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Parabens você ganhou um curso.");
        }
    }
}