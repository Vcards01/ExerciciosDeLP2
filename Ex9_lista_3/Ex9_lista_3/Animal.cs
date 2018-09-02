using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_lista_3
{
    class Animal
    {
        private string nome;
        private int idade;
        private double peso;
        private string raca;
        private Cliente dono;
        private double banho;
        private double valorBanhoPadrão = 3.50;
        


        public void Banho() {
            Console.WriteLine(nome + " tomou banho");
        }
        public void ValorBanho()
        {
            Console.WriteLine("Dono: " + Dono.Nome);
            Console.WriteLine("Raça: " + Raca);
            Console.WriteLine("Nome: " + Nome);
            banho = valorBanhoPadrão* Peso;
            Console.WriteLine("Preço: " + banho);
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

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = (value>=0)?value:0;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = (value >= 0) ? value : 0; 
            }
        }

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
            }
        }

        internal Cliente Dono
        {
            get
            {
                return dono;
            }

            set
            {
                dono = value;
            }
        }
    }
}
