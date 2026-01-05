using ControleDeAnimais.Entidade;
using System;

namespace ControleDeAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;

            Console.WriteLine("Controle de animais");
            Console.WriteLine("Infrome o nome do 1º animal: ");
            a1.Nome = Console.ReadLine();
            
            Console.WriteLine("Infrome o tipo do 1º animal (Cachiorro, gato, Pexie): ");
            a1.Tipo = Console.ReadLine();
            if (a1.Tipo == "Cachorro") tlCachorro++;
            if (a1.Tipo == "Gato") tlGato++;
            if (a1.Tipo == "Peixe") tlGato++;

            Console.WriteLine("Infrome o tipo do 2º animal (Cachiorro, gato, Pexie): ");
            a2.Tipo = Console.ReadLine();
            if (a2.Tipo == "Cachorro") tlCachorro++;
            if (a2.Tipo == "Gato") tlGato++;
            if (a2.Tipo == "Peixe") tlGato++;

            Console.WriteLine("Infrome o tipo do 3º animal (Cachiorro, gato, Pexie): ");
            a3.Tipo = Console.ReadLine();
            if (a3.Tipo == "Cachorro") tlCachorro++;
            if (a3.Tipo == "Gato") tlGato++;
            if (a3.Tipo == "Peixe") tlGato++;

            Console.WriteLine("Infrome o tipo do 4º animal (Cachiorro, gato, Pexie): ");
            a4.Tipo = Console.ReadLine();
            if (a4.Tipo == "Cachorro") tlCachorro++;
            if (a4.Tipo == "Gato") tlGato++;
            if (a4.Tipo == "Peixe") tlGato++;

            Console.WriteLine("Infrome o tipo do 5º animal (Cachiorro, gato, Pexie): ");
            a5.Tipo = Console.ReadLine();
            if (a5.Tipo == "Cachorro") tlCachorro++;
            if (a5.Tipo == "Gato") tlGato++;
            if (a5.Tipo == "Peixe") tlGato++;

            //resultado
            Console.WriteLine();
            Console.WriteLine("Cachorros: "+tlCachorro+"\nGatos: "+tlGato+"\nPeixes: "+ tlPeixe);

        }
    }
}
