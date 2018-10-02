using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_pizza
{
    class Pizza:Produto
    {
        private List<Ingrediente> ingredientes = new List<Ingrediente>();
        public override double Get_Preco()
        {
           return preco=25.50;
        }
        public void ListaIngredientes()
        {
            foreach(Ingrediente c in ingredientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Valor);
            }

        }
        public void add(string nome)
        {
            for (int i = 0; i < ingredientes.Count; i++)
            {
                if (nome == ingredientes[i].Nome)
                {
                    ingredientes.Add(ingredientes[i]);
                    preco=ingredientes[i].Valor+Get_Preco();
                }
            }
        }
        public void remover(string nome)
        {
            for(int i=0;i<ingredientes.Count;i++)
            {
                if(nome==ingredientes[i].Nome)
                {
                    ingredientes.Remove(ingredientes[i]);
                }
            }
        }
    }
}
