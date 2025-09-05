using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc2
{
    class Funcionario
    {
        public string nome;
        public int salario;
        private double imposto;

        public void Dadosfuncionarios()
        {
            double salarioliquido;
            if (salario < 2000) salarioliquido = salario - (salario * 0.10);
            else if (salario < 3000) salarioliquido = salario - (salario * 0.15);
            else salarioliquido = salario - (salario * 0.20);
            Console.WriteLine($"O nome do funcionario é {nome}, e o salario liquido é {salarioliquido}");
        }
    }
}
