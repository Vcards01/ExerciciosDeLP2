using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    interface IDataBase
    {
        void save(Livro l);
        void delete(long codigo);
        void update(Livro l);
        Livro read(long codigo);
        List<Livro> ListAll();
    }
}
