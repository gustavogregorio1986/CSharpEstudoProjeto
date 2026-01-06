using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade.Entidade
{
    public class Pessoa
    {
		private int anoNasicmento;


        public Pessoa(String nomePessoa, int anoNascimentoPessoa)
        {
            this.nome = nomePessoa;
			this.anoNasicmento = anoNascimentoPessoa;
			this.CalcularIdade();
        }

        public int AnoNascimento
		{
			get { return anoNasicmento; }
			set { this.anoNasicmento = value; }
		}

		private String nome;

		public String Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		//Vamos melhorar
		private int idade;

		public int Idade
		{
			
			get {
                this.CalcularIdade();
                return this.idade; 
			}
		}


		public void ExibirDados()
		{
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de Nascimento: " + this.anoNasicmento);
            this.CalcularIdade();
            Console.WriteLine("Idade: " + this.idade);
		}

		private void CalcularIdade()
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			this.idade = ano - this.anoNasicmento;
        }
	}
}
