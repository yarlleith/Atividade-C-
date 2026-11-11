using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Compra aprovada: R$ 45,90 na Padaria Central às 08:30.");
        }
    }
}