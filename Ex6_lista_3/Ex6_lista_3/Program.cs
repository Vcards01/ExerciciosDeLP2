using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_lista_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.Nome = "Jose";
            c1.Cpf = 47560617883;
            Banco b1 = new Banco();
            b1.NumBanco = 1;
            Conta con1 = new Conta(c1, b1);
            c1.AddConta(con1);
            b1.AddConta(con1);
            con1.NumAgencia = 123;
            con1.NumConta = 1;
            con1.TempoConta = 2;

            
        }
    }
}
