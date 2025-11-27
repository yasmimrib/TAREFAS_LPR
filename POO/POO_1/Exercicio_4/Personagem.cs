using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Personagem
    {
        public string nome;
        public int vidas;
        public bool poder, item;

        public void Pular()
        {
            Console.WriteLine(nome + " pulou!");
        }

        public void PegaPoder()
        {
            poder = true;
            Console.WriteLine(nome + " colotou o poder!");
        }

        public void Ataque()
        {
            if (poder)
            {

                Console.WriteLine(nome + " lançou um ataque!");

            }
            else
            {
                Console.WriteLine(nome + " pulou no inimigo!");
            }
        }

        public void ColetaItem()
        {
            item = true;
            Console.WriteLine(nome + " coletou um novo item!");
        }

    }
}
