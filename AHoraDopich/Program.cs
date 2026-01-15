using AHoraDopich.Entidade;
using System;

namespace AHoraDopich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarme alarme = new Alarme();
            String resposta = "S";
            while(resposta!="N")
            {
                Console.Clear();
                Console.WriteLine("A Hora do Pitch");
                Console.WriteLine("Informe a duração do Pitch: ");
                int tempo = int.Parse(Console.ReadLine());

                alarme.Tempo = tempo;

                alarme.Iniciar();
                Console.WriteLine("Que pena!!! O seu tempo acabou!!");
                Console.WriteLine("Executar o programa novamente: S/N");
                resposta = Console.ReadLine().ToUpper().ToUpper();
            }
            
        }
    }
}
