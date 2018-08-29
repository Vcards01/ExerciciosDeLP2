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
        private int qtdd;
        private string nome;
        private long cpf;
        private Conta[] contas = new Conta[MAX];

        public Cliente()
        {
            qtdd = 0;
        }

        public void AddConta(Conta c1)
        {
            for (int i = 0; i < MAX; i++)
            {
                if (qtdd < MAX)
                {
                    contas[i] = c1;
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
                    if (contas[i] == c1)
                    {
                        idx = i;
                        break;
                    }
                }
                for (int i = idx; i < qtdd - 1; i++)
                    contas[i] = contas[i + 1];
                contas[qtdd - 1] = null;
                qtdd--;
         }
        
        public void ListarContas()
        {
            for(int i=0;i<qtdd;i++)
            {
                Console.WriteLine("Conta" + i);
                Console.WriteLine(contas[i].NumConta);
                Console.WriteLine(contas[i].NumAgencia);
                Console.WriteLine(contas[i].Saldo);
                Console.WriteLine(contas[i].Limite+"\n\n\n\n");
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

