using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_lista_3
{
    class Cachorro:Animal
    {
        private double tosa;
        private double valorTosaPadrão = 4.50;
        public void Tosa()
        {
            Console.WriteLine(Nome + " foi tosado");
        }
        public void ValorTosa()
        {
            Console.WriteLine("Dono: " + Dono.Nome);
            Console.WriteLine("Raça: " + Raca);
            Console.WriteLine("Nome: " + Nome);
            tosa = valorTosaPadrão * Peso;
            Console.WriteLine("Preço: " + tosa);
        }
    }
    
}
