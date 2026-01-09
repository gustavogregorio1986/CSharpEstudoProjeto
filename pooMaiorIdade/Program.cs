using pooMaiorIdade.Entidade;
using System;

namespace pooMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;
            Console.WriteLine("Determina qual é pessoa a mais velha");
            //Leitura de dados da 1 pessoa
            Console.WriteLine("Nome da 1º pessoa: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 1º pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());
            //Leitura de dados da 1 pessoa
            Console.WriteLine("Nome da 2º pessoa: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 2º pessoa: ");
            p2.Idade = int.Parse(Console.ReadLine());
            //Leitura de dados da 3 pessoa
            Console.WriteLine("Nome da 3º pessoa: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Idade da 3º pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            p3 = new Pessoa(nome, idade);
            //Lófgica
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirMaiorIdade();
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais belha é: ");
                    p2.ExibirMaiorIdade();
                }
                else
                {
                    if((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                    {
                        Console.WriteLine("A pessoa m,ais velha é? ");
                        p3.ExibirMaiorIdade();
                    }
                    else
                    {
                        Console.WriteLine("A pessoa m,ais velha é? ");
                    }
                }
            }
        }
    }
}
