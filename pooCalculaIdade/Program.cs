using pooCalculaIdade.Entidade;
using System;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a Idade de uma pessoa");

            Pessoa p = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de nascimento: ");
            p.AnoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine(p.Idade); 
            //p.ExibirDados();

        }
    }
}
