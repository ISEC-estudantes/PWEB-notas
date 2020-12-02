using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_ex3
{
    class Triangulo:FiguraPlana
    {
        public int lado1 { get; private set; }
        public int lado2 { get; private set; }
        public int lado3 { get; private set; }

        public Triangulo(int lado1, int lado2, int lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override Double Area()
        {
            double hperi = Perimetro() / 2;

            return Math.Sqrt(hperi * (hperi-lado1)*(hperi - lado2) *(hperi - lado3));
        }

        public override Double Perimetro()
        {
            return lado3 + lado2 + lado1;
        }

    }
}
