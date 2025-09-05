using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double calcArea()
        {
            double area = (Altura * Largura);
            return area;
        }
        public double calcPerimetro()
        {
            double perimetro = (2 * Largura) + (2 * Altura);
            return perimetro;
        }
    }
}
