using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_livros_1
{
    interface IDataBase
    {
        void Save(Livro l);
        void Delete(long codigo);
        void Update(Livro l);
        Livro Read(long codigo);
        List<Livro> ListAll();       
    }
}
