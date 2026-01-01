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
            Console.WriteLine("Digite vo nome da pessoa: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o anod e nascimento: ");
            p.AnoNascimento = int.Parse(Console.ReadLine());
            p.ExibirDados();

        }
    }
}
