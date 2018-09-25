using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_pizza
{
    class Ingrediente
    {
        private string nome;
        private double valor=2.50;
        private Pizza sabor;

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

        public double Valor
        {
            get
            {
                return valor;
            }

            
        }

        internal Pizza Sabor
        {
            get
            {
                return sabor;
            }

            set
            {
                sabor = value;
            }
        }
    }
}
