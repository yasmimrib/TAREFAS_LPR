using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class retangulo
    {
        public double largura;
        public double altura;

        public double calcArea()
        {
            return largura * altura;

        }
        public double calcPerimetro()
        {
            return 2 * (largura + altura);
        }
    }
}