using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Item
    {
        public string nome, efeito;

        public void usoItem()
        {
            Console.WriteLine("O item " + nome + " foi usado e causou o efeito: " + efeito);
        }
    }
}
