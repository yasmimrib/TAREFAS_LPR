using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class Livros
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int anoPublicacao { get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Autor: {Autor}, Ano de Publicação: {anoPublicacao}");
        }
    }
}
