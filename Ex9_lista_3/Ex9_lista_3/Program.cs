using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_lista_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de Animais
            Cachorro k1 = new Cachorro();
            Gato g1 = new Gato();
            //alterando estado dos animais
            k1.Nome = "Toto";
            k1.Idade = 2;
            k1.Peso = 21.5;
            k1.Raca = "Labrador";
            //-------//
            g1.Nome = "Pingo";
            g1.Idade = 3;
            g1.Peso = 15;
            g1.Raca = "Siames";
            //Criação de Clientes
            Cliente c1 = new Cliente();
            //Alterando estado dos clientes
            c1.Nome = "Lucas";
            c1.Cpf = 476607783;
            //Adicionando animais ao Cliente
            c1.addAnimal(k1);
            c1.addAnimal(g1);
            //Mostrando todos os Animais do Cliente
            c1.list();
            Console.Write("\n");
            //Adicionando dono aos animais
            Console.Write("\n");
            k1.Dono = c1;
            g1.Dono = c1;
            //Dando banho nos animais
            Console.Write("\n");
            k1.Banho();
            Console.Write("\n");
            g1.Banho();
            //Exibindo as faturas
            Console.Write("\n");
            k1.ValorBanho();
            g1.ValorBanho();
            //Tosando
            Console.Write("\n");
            k1.Tosa();
            //exibindo fatura
            Console.Write("\n");
            k1.ValorTosa();
            Console.Read();
            

            
            
        }
    }
}
