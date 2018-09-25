using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_pizza
{
    class ItemPedido
    {
        private int id;
        private DiskPizza pizzaria;
        private Produto produto;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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
    }
}
