using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AHoraDopich.Entidade
{
    public class Alarme
    {
        public Alarme()
        {
            this.Tempo = 3; //três minutos
        }

        public Alarme(int tempo)
        {
            this.Tempo = tempo;
        }

        //controla o tempo do Pitch
        private int tempo;

		public int Tempo
		{
			get { return tempo; }
			set { tempo = 1000 * 60 * value; }
		}

        public void Iniciar()
        {
            Thread.Sleep(this.Tempo);
            Console.Beep(150,1000);
        }

	}
}
