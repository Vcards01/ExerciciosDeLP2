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
        private string nome;
        private long cpf;
        private Conta[] contas = new Conta[MAX];

      
        public void ListarContas()
        {
            for(int i=0;i<MAX;i++)
            {
                Console.WriteLine("Conta"+i);
                Console.WriteLine(contas[i].NumAgencia);
                Console.WriteLine(contas[i].NumConta);
                Console.WriteLine(contas[i].Saldo);
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
                cpf = (value >= 0) ? value : 0;
            }
        }

    }

}
