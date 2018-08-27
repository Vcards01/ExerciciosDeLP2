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
        private double saldo;
        private double limite;
        private int tempoConta;


        public bool Sacar(double valor, long senha)
        {
            if(senha==Senha)
            {
                if(valor<=Saldo+Limite)
                {
                    Saldo =Saldo- valor;
                    Console.WriteLine("Saque realizado com sucesso");
                    return true;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("senha incorreta");
                return false;
            }
        }
        public void depositar(double valor, long senha)
        {
            if (senha == Senha)
            {
                Saldo = Saldo + valor;
                Console.WriteLine("Deposito feito com sucesso");
            }
            else
            {
                Console.WriteLine("Senha invalida");
            }
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

            set
            {
                saldo = value;
            }
        }

        public double Limite
        {
            get
            {
                return limite;
            }

            set
            {
                limite = value;
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

        
    }
}
