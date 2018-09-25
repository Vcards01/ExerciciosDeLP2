using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_pizza
{
    class Produto
    {
        private string nome;
        private double preco;
        private int numero;
        private ItemPedido pedido;
        private DiskPizza pizzaria;

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

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        internal ItemPedido Pedido
        {
            get
            {
                return pedido;
            }

            set
            {
                pedido = value;
            }
        }

        internal DiskPizza Pizzaria
        {
            get
            {
                return pizzaria;
            }

            set
            {
                pizzaria = value;
            }
        }

        public virtual void Get_Preco()
        {
            Preco=4.50;
        }

    }
}
