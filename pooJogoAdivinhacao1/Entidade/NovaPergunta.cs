using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao1.Entidade
{
    public class NovaPergunta:PerguntaJogo
    {
        public NovaPergunta()
        {
            this.Dica = "";

        }

        public NovaPergunta(String pergunta, String resposta, String dica):base(pergunta, resposta)
        {
            this.Dica = dica;
            base.Pergunta = pergunta;
        }

        public String Dica { get; set; }
    }
}
