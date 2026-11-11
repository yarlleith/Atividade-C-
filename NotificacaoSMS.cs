using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class NotificacaoSMS : Notificacao 
    {
        public override void Enviar()
        {
            Console.WriteLine("Seu código é 041248");
        }
    }
}