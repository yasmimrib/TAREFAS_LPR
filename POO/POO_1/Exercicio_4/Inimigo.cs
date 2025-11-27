using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Inimigo
    {
        public string nome;
        public int forca;

        public void Atacar()
        {
            Console.WriteLine(nome + " atacou com força " + forca + "!");
        }

        public void Dano()
        {
            Console.WriteLine(nome + " tomou dano!");
        }
    }
}
