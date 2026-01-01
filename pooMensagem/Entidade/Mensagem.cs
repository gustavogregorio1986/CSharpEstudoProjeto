using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem.Entidade
{
    public class Mensagem
    {
        //private String TextoMensagem;

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

        //public String getTextoMensagem()
        //{
        //     return this.TextoMensagem;
        //}

        // public void setTextoMensagem(String valor)
        // {
        //     this.TextoMensagem = valor.ToUpper();
        // }

        private String textoMensagem;

        public String TextoMensagem
        {
            get 
            { 
                return textoMensagem; 
            }
            
            set 
            { 
                textoMensagem = value.ToUpper().ToUpper(); 
            }
        }   
    }
}
