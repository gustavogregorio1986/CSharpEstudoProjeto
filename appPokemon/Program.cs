using pooPokemonApp.Entidade;
using System;

namespace pooPokemonApp
{
    public class Program
    {
        static void Main(string[] args)
        {
           Pokemon p = new Pokemon();
           p.Nome = "Bulbasauro";
           p.Descricao = "Bulbasauro é um Pokémon do tipo grama/veneno da primeira geração...";

           p.ExibirDadosPokemon();
        }
    }
}
