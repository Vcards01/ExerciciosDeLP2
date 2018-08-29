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

        public Banco()
        {
            qtdd = 0;
        }
        public void ListarContas()
        {
            for (int i = 0; i < qtdd; i++)
            {
                Console.WriteLine("Numero"+contasB[i].NumConta);
                Console.WriteLine("Agencia"+contasB[i].NumAgencia);
                Console.WriteLine("Saldo"+contasB[i].Saldo);
                Console.WriteLine("Limite" + contasB[i].Limite);
            }
        }
        public void ListarContas(double numAgencia)
        {
            for (int i = 0; i < qtdd; i++)
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
                    qtdd++;
                    break;
                }
            }

        }
        public void RemoveConta(Conta c1)
        {
            int idx = -1;
            for (int i = 0; i < qtdd; ++i)
            {
                if (contasB[i] == c1)
                {
                    idx = i;
                    break;
                }
            }
            for (int i = idx; i < qtdd - 1; i++)
                contasB[i] = contasB[i + 1];
            contasB[qtdd - 1] = null;
            qtdd--;
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
