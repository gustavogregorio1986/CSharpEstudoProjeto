using pooCalculaIdade.Entidade;
using System;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a Idade de uma pessoa");
            Console.WriteLine("Nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());
            Pessoa p;
            p = new Pessoa(nome, ano);
            p.ExibirDados();
            //Pessoa p = new Pessoa("Gustavo", 1986);
            //p.ExibirDados();
            //Console.WriteLine(p.Nome);
            //Console.WriteLine("Digite o nome da pessoa: ");
            //p.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o ano de nascimento: ");
            //p.AnoNascimento = int.Parse(Console.ReadLine());
            //Console.WriteLine(p.Idade); 
            //p.ExibirDados();

        }
    }
}
