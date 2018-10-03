using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_livros_1
{
        
    class BDDicionario : IDataBase
    {
        private static Dictionary<long, Livro> livro = new Dictionary<long, Livro>();
        public void Delete(long codigo)
        {
            livro.Remove(codigo);
        }

        public List<Livro> ListAll()
        {
            return livro.Values.ToList<Livro>();
        }

        public Livro Read(long codigo)
        {
            return livro[codigo];
        }

        public void Save(Livro l)
        {
            l.Codigo = livro.Count;
            livro.Add(l.Codigo, l);
        }

        public void Update(Livro l)
        {
            livro[l.Codigo]=l;
        }
    }
}
