using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_ex3
{
    
    class Retangulo:FiguraPlana
    {
        
        public int comprimento { get; private set; }
        public int largura { get; private set; }
        
        public Retangulo(int comprimento, int largura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
        }

        public override Double Area()
        {
            return comprimento * largura;
        }

        public override Double Perimetro()
        {
            return 2*comprimento+2*largura;
        }





    }
}
