using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_lista_3
{
    class Cliente
    {
        private const int MAX = 10;
        private int qtdd = 0;
        private string nome;
        private long cpf;
        private Conta[] contas = new Conta[MAX];

        public void AddConta(Conta c1)
        {
            for (int i = 0; i < MAX; i++)
            {
                if (qtdd < MAX)
                {
                    contas[i] = c1;
                }
            }

        }
        public void RemoveConta(Conta c1)
        {
            for (int i = 0; i < MAX; i++)
            {
                if (contas[i] == c1)
                {
                    for (int j = i; j < MAX; j++)
                    {
                        contas[j] = contas[j + 1];
                    }
                    qtdd--;
                }
            }
        }
        public void ListarContas()
        {
            for(int i=0;i<MAX;i++)
            {
                Console.Write(contas[i].NumConta);
                Console.Write(contas[i].NumAgencia);
                Console.Write(contas[i].Saldo);
                Console.Write(contas[i].Limite);
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
    }
}
}
