using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_teste
{
    interface IDataBase
    {
       void Create(Funcionario f);
       Funcionario Read(string cpf);
       void Update(Funcionario f);
       void Delete(string cpf);
       List<Funcionario> ListAll();   
    }
}
