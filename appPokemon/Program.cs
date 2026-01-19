using pooPokemonApp.Entidade;
using System;

namespace pooPokemonApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            Pokemon p = pokedex.Pokeomns[1];
            p.ExibirDadosPokemon();

            //Pokemon p = new Pokemon();
            //p.Nome = "Bulbasauro";
            //p.Descricao = "Bulbasauro é um Pokémon do tipo grama/veneno da primeira geração...";

            //p.ExibirDadosPokemon();

            //Pokemon p1 = new Pokemon("Bulbasauro", "Bulbasauro é um Pokémon do tipo grama/veneno da primeira geração...");
            //p1.ExibirDadosPokemon(true);
        }
    }
}
