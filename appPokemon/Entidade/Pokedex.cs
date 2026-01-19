using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp.Entidade
{
    public class Pokedex
    {
		private List<Pokemon> pokemons;

        public Pokedex()
        {
            this.Inicializar();
        }

        public List<Pokemon> Pokeomns
		{
			get { return pokemons; }
		}

		private void Inicializar()
		{
            //Instanciar a lista
			this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bulbasauro","Sua descrição");
			this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Sua descrição");
            this.pokemons.Add(p);
        }
    }
}
