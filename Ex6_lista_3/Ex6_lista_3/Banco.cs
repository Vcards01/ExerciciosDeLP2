using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_lista_3
{
    class Banco
    {
        private const int MAX = 100;
        private int numBanco;
        private Conta[] contas = new Conta[MAX]; 

        public void ListarContas()
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Conta" + i);
                Console.WriteLine(contas[i].NumAgencia);
                Console.WriteLine(contas[i].NumConta);
                Console.WriteLine(contas[i].Saldo);
            }
        }
        public void ListarContas(long numAgencia)
        {
            for (int i = 0; i < MAX; i++)
            {
                if(contas[i].NumAgencia==numAgencia)
                {
                    Console.WriteLine("Conta" + i);
                    Console.WriteLine(contas[i].NumConta);
                    Console.WriteLine(contas[i].Saldo);
                }
                
            }
        }

        public int NumBanco
        {
            get
            {
                return numBanco;
            }

            set
            {
                numBanco = (value>=0)?value:0;
            }
        }
    }
}
