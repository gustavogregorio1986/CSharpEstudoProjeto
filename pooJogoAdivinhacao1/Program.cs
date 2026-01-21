using pooJogoAdivinhacao1.Entidade;
using System;
using System.Collections.Generic;

namespace pooJogoAdivinhacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();
        }

        static List<NovaPergunta> CriarPerguntas()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            NovaPergunta p = new NovaPergunta("Qual a cor do céi?","Azul","Informe uma cor que comece com a letra A");
            return lista;
        }
    }
}
