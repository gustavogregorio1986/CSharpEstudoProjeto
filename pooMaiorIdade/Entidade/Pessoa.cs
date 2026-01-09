using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade.Entidade
{
    public class Pessoa
    {
		private String nome;

        public Pessoa()
        {
            this.nome = "";
            this.Idade = 0;
        }

        public Pessoa(String nome, int idade)
        {
            this.nome = nome;
            this.Idade = idade;
        }

        public String Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		public int Idade { 
            get { return Idade; }
            set {  
                if(value >= 0)
                {
                    Idade = value;
                }
                else
                {
                    this.Idade = 0;
                }
            } 
        }
		//Metodos
		public void ExibirMaiorIdade()
		{
            Console.WriteLine("Nome: " + this.nome);
        }
    }
}
