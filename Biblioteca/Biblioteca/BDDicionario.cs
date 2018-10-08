using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class BDDicionario : IDataBase
    {
        private Dictionary<long, Livro> livros = new Dictionary<long, Livro>();

        public void delete(long codigo)
        {
            livros.Remove(codigo);
        }

        public List<Livro> ListAll()
        {
            return livros.Values.ToList<Livro>();
        }

        public Livro read(long codigo)
        {
            return livros[codigo];
        }

        public void save(Livro l)
        {
            l.Codigo = livros.Count;
            livros.Add(l.Codigo, l);
        }

        public void update(Livro l)
        {
            livros[l.Codigo] = l;
        }
    }
}
