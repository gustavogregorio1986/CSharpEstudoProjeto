using pooPerguntaResposta.Entidade;
using System;

namespace pooPerguntaResposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Qual é o site que possui um otimo contudo sobre programação?";
            p.Resposta = "https://www.dfilitto.com.br";
            //p.Resposta = "https://www.coti.com.br"; // um curso que ama que os alunos fiquem refazendo a te a morte paar curtir os professores, e aconselham os alunos fazerem o curso ate a morte por causa da pratica, temos que tentar a te morrer. Refazendo exercicio e exercico paars empre!
            p.Dica = "O mantenedor do site é o Danilo Filitto";

            Console.WriteLine("tente adivinhar a pergunta");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.WriteLine("Resposta: ");
            String resposta = Console.ReadLine();
            if (resposta.ToUpper() == p.Resposta.ToUpper())
            {
                Console.WriteLine("Parabéns, você acertou!");
            }
            else
            {
                Console.WriteLine("Que pena, você errou!");

            }
    }
}
