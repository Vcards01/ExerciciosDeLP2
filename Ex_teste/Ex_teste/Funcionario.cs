using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_teste
{
   public abstract  class Funcionario
    {
        private string cpf;
        private string nome;
        private int idade;
        private string sexo;
        private double valorVendido;

       

        public Funcionario(string cpf, string nome, int idade, string sexo, double valorVendido)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.ValorVendido = valorVendido;
        }

        public string Cpf
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
                idade = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public double ValorVendido
        {
            get
            {
                return valorVendido;
            }

            set
            {
                valorVendido = value;
            }
        }

       

        public abstract double calculaComissao();
        
    }
}
