using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_pizza
{
    class DiskPizza
    {
        private string nome;
        private List<ItemPedido> pedidos = new List<ItemPedido>();
        private List<Produto> produtos = new List<Produto>();
        private Dictionary<long, Cliente> Clientes = new Dictionary<long, Cliente>();


        public int IniciaPedido(long tel)
        {
            if(Clientes.ContainsKey(tel))
            {

            }
            else
            {
                Clientes[Clientes.Count].Nome = Console.ReadLine();
                Clientes[Clientes.Count].Endereco = Console.ReadLine();
                Clientes[Clientes.Count].Cpf = long.Parse(Console.ReadLine());
                Clientes[Clientes.Count].Telefone =tel;
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

        
    }
}
