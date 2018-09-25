using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_pizza
{
    class Cliente
    {
        private string nome;
        private string endereco;
        private long cpf;
        private long telefone;
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

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
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

        public long Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
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
