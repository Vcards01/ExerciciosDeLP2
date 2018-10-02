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
        protected double preco;
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

        public virtual double Get_Preco()
        {
            return preco=4.50;
        }

    }
}
