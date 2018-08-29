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
            Cliente c2 = new Cliente();
            c1.Nome = "Jose";
            c1.Cpf = 47560617883;
            c2.Nome = "carlos";
            c2.Cpf = 123456789;
            Banco b1 = new Banco();
            b1.NumBanco = 1;
            Conta con1 = new Conta(c1, b1);
            Conta con2 = new Conta(c2, b1);
            con1.NumAgencia = 123;
            con1.NumConta = 1;
            con1.TempoConta = 2;
            con1.Senha = 123;
            Console.WriteLine("Saldo:" + con1.Saldo);
            con1.Depositar(300, 123);
            Console.WriteLine("Saldo:" + con1.Saldo);
            con1.Sacar(100, 123);
            Console.WriteLine("Saldo:" + con1.Saldo);
            c1.AddConta(con1);
            b1.AddConta(con1);
            Console.WriteLine("Lista contas cliente:");
            c1.ListarContas();
            Console.WriteLine("Lista contas banco:");
            b1.ListarContas();
            Console.WriteLine("Limite:" + con1.Limite);
            con1.SolcitarLimite(500, 123);
            Console.WriteLine("Limite:" + con1.Limite);
            con1.SolcitarLimite(900, 123);
            Console.WriteLine("Limite:" + con1.Limite);
            c1.RemoveConta(con1);
            b1.RemoveConta(con1);
            Console.Read();


        }
    }
}
