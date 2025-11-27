using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class funcionario
    {
        public string nome;
        public double salario;

        public string dadosFuncionario()
        {
            return "Nome: " + nome + ", Salario: " + salario;
        }

        public double aumentoSalario()
        {
            if (salario <= 2000)
            {
                salario += salario * (10 / 100.0);
            }

            else if (salario > 2000 && salario <= 3000)
            {
                salario += salario * (15 / 100.0);
            }

            else if (salario > 3000)
            {
                salario += salario * (20 / 100.0);
            }
            return salario;
        }

    }
}