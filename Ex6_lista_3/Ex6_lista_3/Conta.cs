using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_lista_3
{
    class Conta
    {
        private long numConta;
        private long numAgencia;
        private long senha;
        private double saldo=0;
        private double limite=100;
        private int tempoConta;
        private Cliente clienteC;
        private Banco bancoC;

        public Conta(Cliente c1,Banco b1)
        {
            ClienteC = c1;
            BancoC = b1;
        }
        public bool Sacar(double valor, long senha)
        {
            if (senha == Senha)
            {
                saldo = Saldo - valor;
                return true;
            }
            else
            { return false; }

        }
        public void Depositar(double valor, long senha)
        {
            if (senha == Senha)
            {
                saldo = Saldo + valor;
            }
            
        }
        public double SolcitarLimite(double valor, long senha)
        {
            if(senha==Senha)
            {
                if( bancoC.AprovarLimite(valor, TempoConta)==1)
                {
                   limite = Limite + valor;
                    return 1;
                }
            }
            return 0;
        }

        public long NumConta
        {
            get
            {
                return numConta;
            }

            set
            {
                numConta = value;
            }
        }

        public long NumAgencia
        {
            get
            {
                return numAgencia;
            }

            set
            {
                numAgencia = value;
            }
        }

        public long Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            
        }

        public double Limite
        {
            get
            {
                return limite;
            }

            
        }

        public int TempoConta
        {
            get
            {
                return tempoConta;
            }

            set
            {
                tempoConta = value;
            }
        }

        internal Cliente ClienteC
        {
            get
            {
                return clienteC;
            }

            set
            {
                clienteC = value;
            }
        }

        internal Banco BancoC
        {
            get
            {
                return bancoC;
            }

            set
            {
                bancoC = value;
            }
        }
    } 
}
