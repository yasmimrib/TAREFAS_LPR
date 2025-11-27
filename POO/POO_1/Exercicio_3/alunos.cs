using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class alunos
    {
        public int Matricula;
        public string Nome;
        public double NotaProva1, NotaProva2, NotaTrabalho, Media, QuantoFalta;


        public alunos(int matricula, string nome, double notaProva1, double notaProva2, double notaTrabalho)
        {
            Matricula = matricula;
            Nome = nome;
            NotaProva1 = notaProva1;
            NotaProva2 = notaProva2;
            NotaTrabalho = notaTrabalho;

        }
        public double mediaFinal()
        {

            Media = ((NotaProva1 * 2.5) + (NotaProva2 * 2.5) + (NotaTrabalho * 2)) / 7;
            return Media;

        }

        public double final()
        {
            if (Media >= 7)
            {
                return 0.0;
            }
            else
            {
                QuantoFalta = 10 - Media;
                return QuantoFalta;
            }
        }

    }
}
