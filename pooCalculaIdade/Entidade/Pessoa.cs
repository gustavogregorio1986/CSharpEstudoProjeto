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

		public void ExibirDados()
		{
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de Nascimento: " + this.anoNasicmento);
            int idade = this.CalcularIdade();
            Console.WriteLine("Idade: " + idade);
		}

		private int CalcularIdade()
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			int idade = ano - this.anoNasicmento;
			return idade;
        }
	}
}
