using pooMensagem.Entidade;
using System;

namespace pooMensagem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;

            msg1 = new Mensagem();
            msg1.TextoMensagem = "Olá, Mundo!";
            msg1.ExibirMensagem();

            msg2 = new Mensagem();
            msg2.TextoMensagem = "Programação Orientada a Objetos";
            msg2.ExibirMensagem();
        }
    }
}
