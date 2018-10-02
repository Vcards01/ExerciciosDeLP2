using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_pizza
{
    class DiskPizza
    {
        private int pro;
        private string nome;
        private List<ItemPedido> pedidos = new List<ItemPedido>();
        private List<Produto> produtos = new List<Produto>();
        private Dictionary<long, Cliente> Clientes = new Dictionary<long, Cliente>();


        public int IniciaPedido(long tel)
        {
            if(Clientes.ContainsKey(tel))
            {
                Console.WriteLine("Digite o numero do produto");
                pro = int.Parse(Console.ReadLine());
                for(int i=0;i<produtos.Count;i++)
                {
                    if(pro==produtos[i].Numero)
                    {
                        
                    }
                }
            }
            else
            {
                Clientes[Clientes.Count].Nome = Console.ReadLine();
                Clientes[Clientes.Count].Endereco = Console.ReadLine();
                Clientes[Clientes.Count].Cpf = long.Parse(Console.ReadLine());
                Clientes[Clientes.Count].Telefone =tel;
            }
        }
        public void addProduto(Produto p)
        {
            if(produtos.Contains(p))
            {
                Console.WriteLine("Produto ja esta cadastrado");     
            }
            else
            {
                produtos.Add(p);
            }
        }
        public void rmProduto(Produto p)
        {
            if(!produtos.Contains(p))
            {
                Console.WriteLine("Produto não existe");

            }
            else
            {
                produtos.Remove(p);
            }
        }
        public void listaIngredientes(Produto p)
        {
            if(produtos.Contains(p))
            {
                if(p is Pizza)
                {
                    ((Pizza)p).ListaIngredientes();
                }
                else
                {
                    Console.WriteLine("Este produto se trata de uma bebida de não uma pizza");
                }
            }
            else
            {
                Console.WriteLine("Produto não faz parte do cardapio");

            }
        }
        public void AddIngrendientes()

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
