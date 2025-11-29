using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class Biblioteca
    {
        public int Id { get; set; }
        public List<Livros> Livros { get; set; } = new List<Livros>();
        public void AdicionarLivro(Livros livro)
        {
            Livros.Add(livro);
        }
        public List<Livros> ListarLivro()
        {
            var existentes = new List<Livros>();
            return Livros;
        }
    }

}
