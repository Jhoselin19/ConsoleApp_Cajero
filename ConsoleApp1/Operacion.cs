using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operacion
    {
        public int ValorA { get; set; }

        public int ValorB { get; set; }

        public int Exponente { get; set; }

        public int Sumar()
        {
            return ValorA + ValorB;

        }

        public int Restar()
        {
            return ValorA - ValorB;
        }
    }
}
