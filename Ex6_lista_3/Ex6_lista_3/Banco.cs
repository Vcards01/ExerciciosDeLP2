using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_lista_3
{
    class Banco
    {
        private const int MAX = 10;
        private int qtdd = 0;
        private int numBanco;
        private Conta[] contasB = new Conta[MAX];

        public void ListarContas()
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.Write(contasB[i].NumConta);
                Console.Write(contasB[i].NumAgencia);
                Console.Write(contasB[i].Saldo);
                Console.Write(contasB[i].Limite);
            }
        }
        public void ListarContas(double numAgencia)
        {
            for (int i = 0; i < MAX; i++)
            {
                if (numAgencia == contasB[i].NumAgencia)
                {
                    Console.Write(contasB[i].NumConta);
                    Console.Write(contasB[i].NumAgencia);
                    Console.Write(contasB[i].Saldo);
                    Console.Write(contasB[i].Limite);
                }
                    
            }
        }
        public void AddConta(Conta c1)
        {
            for (int i = 0; i < MAX; i++)
            {
                if (qtdd < MAX)
                {
                    contasB[i] = c1;
                }
            }

        }
        public void RemoveConta(Conta c1)
        {
            for (int i = 0; i < MAX; i++)
            {
                if (contasB[i] == c1)
                {
                    for (int j = i; j < MAX; j++)
                    {
                        contasB[j] = contasB[j + 1];
                    }
                    qtdd--;
                }
            }
        }
        public double AprovarLimite(double valor,int tempoConta)
        {
            if(valor<=200+(300*tempoConta))
            {
                return 1;
            }
            return 0;
            
        }

        public int NumBanco
        {
            get
            {
                return numBanco;
            }

            set
            {
                numBanco = value;
            }
        }
    }
}
