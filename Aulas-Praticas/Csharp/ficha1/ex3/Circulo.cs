using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_ex3
{
    class Circulo:FiguraPlana
    {
        public int raio { get; private set; }

        public Circulo(int raio)
        {
            this.raio = raio;
        }

        public override double Area()
        {
            return Math.PI * raio * raio;

        }

        public override double Perimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
