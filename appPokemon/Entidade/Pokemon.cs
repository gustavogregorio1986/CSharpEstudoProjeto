using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp.Entidade
{
    public class Pokemon
    {
		public Pokemon()
		{
			this.Nome = "";
            this.Descricao = "";
        }

        private string nome;

		public String Nome
		{
			get { 
			    	
				return nome; 
			}
			set {
                String texto = value.ToUpper();
                nome = texto;
            }
		}

		private String descricao; //armazena com valor da propriedade Descirção

		public String Descricao //represneta a caracteristica Descrição do meu Pokemon
        {
			get { return descricao; }
			set {
				this.descricao = value.ToUpper(); 
			}
		}

		public void ExibirDadosPokemon()
		{
			Console.WriteLine("Nome do Pkemon: " + this.Nome);
			Console.WriteLine("Descrição: " + this.Descricao);
        }

    }
}
