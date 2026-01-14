using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo.Entidade
{
    public class Retangulo
    {
        public Retangulo()
        {
            
        }

        private int baseret;

        public int Base
        {
            get { return baseret; }
            set { 
               if(value >= 0) baseret = value; 
               else baseret = 0;
            }
        }

        //altura do retângulo
        private int altret;

        public int Altura
        {
            get { return altret; }
            set { 
               if(value >= 0) altret = value;
               else altret = 0;
            }
        }

        public int Area
        {
            get { return altret*baseret; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: " + this.Area);
        }
    }
}
